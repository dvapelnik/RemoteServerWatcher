using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using System.Drawing;

namespace RemoteServerWatcher {
    public partial class MainForm : Form {
        #region Constatnts
        public const string TimerInterval = "timer-interval-seconds";
        public const string StartTimerOnLoad = "start-timer-on-load";
        public const string ChartRange = "chart-range";
        public const string OverloadValue = "overload-value";
        public const string AlertOnOverload = "0";
        public const string OverloadAlertPeriodMinutes = "overload-alert-period";
        public const string OverloadAlertBalloonIntervalToShowSecond = "overload-alert-ballon-interval-to-show";

        public const string GrayIcon = "grey_icon.ico";
        public const string GreenIcon = "green_icon.ico";
        public const string RedIcon = "red_icon.ico";
        #endregion

        private string dataStorageFileNameOptions = "settings.xml";
        private string dataStorageFileNameServers = "servers.xml";

        private DateTime lastOverloadAlertDateTimeMoment = DateTime.MinValue;

        public DataProtectionScope scope;
        private Cryptor cryptor;

        internal Storage storage = null;
        internal Timer timer;

        public MainForm() {
            this.Name = "MainForm";
            this.scope = DataProtectionScope.LocalMachine;
            this.cryptor = new Cryptor(this.scope);
            this.storage = new Storage();

            #region Servers and options file
            if (!File.Exists(this.dataStorageFileNameOptions)) {
                this.GenerateDefaultOptions();
                this.SaveOptionsToFile(this.dataStorageFileNameOptions, this.storage.options);
            }
            if (!File.Exists(this.dataStorageFileNameServers)) {
                this.GenerateDefaultServers();
                this.SaveServersToFile(this.dataStorageFileNameServers, this.storage.servers);
            }
            #endregion

            this.LoadOptions();
            this.LoadServers();
            InitializeComponent();

            this.timer = new Timer() { Interval = Int32.Parse(this.storage.GetOption("timer-interval-seconds")) };
            this.timer.Tick += timer_Tick;
            if (this.storage.GetOption("start-timer-on-load") == "1") {
                this.timer.Start();
            }

            SetStopStartButtonStatus();

            foreach (Server _server in storage.servers) {
                if (_server.enabled) {
                    Series _series = new Series(_server.name);
                    _series.ChartType = SeriesChartType.Spline;
                    chartServers.Series.Add(_series);
                }
            }

            chartServers.ChartAreas["ChartAreaServersLA"].Axes[1].Maximum = 0;

            UpdateServesComboBox();

            textBoxCommand.Focus();

            backgroundWorkerForServers.DoWork += backgroundWorkerForServers_DoWork;
            backgroundWorkerForServers.RunWorkerCompleted += backgroundWorkerForServers_RunWorkerCompleted;

            backgroundWorkerForCommand.DoWork += backgroundWorkerForCommand_DoWork;
            backgroundWorkerForCommand.RunWorkerCompleted += backgroundWorkerForCommand_RunWorkerCompleted;

            notifyIconTray.Text = this.Text;
            notifyIconTray.BalloonTipShown += delegate(object sender, EventArgs e) {
                this.lastOverloadAlertDateTimeMoment = DateTime.Now;
            };
        }

        void backgroundWorkerForCommand_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e) {
            richTextBoxLog.Text += e.Result as string;
            textBoxCommand.Clear();
            textBoxCommand.Focus();
        }

        void backgroundWorkerForCommand_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) {
            Dictionary<string, object> _argument = e.Argument as Dictionary<string, object>;
            Server _server = _argument["server"] as Server;
            string _command = _argument["command"] as string;

            string _result = _server.GetCommandResult(_command);

            e.Result = String.Format("{0}:\n{1}\n", _server.host, _result) as object;
        }

        void backgroundWorkerForServers_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e) {
            UpdateChart();
            //this.Invoke(new MethodInvoker(delegate { toolStripStatusLabelBackgroundWorkerStatus.ForeColor = Color.Green; }));
        }

        void backgroundWorkerForServers_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) {
            //this.Invoke(new MethodInvoker(delegate { toolStripStatusLabelBackgroundWorkerStatus.ForeColor = Color.Red; }));
            CollectNewUptimeData();
        }

        private void SetStopStartButtonStatus() {
            buttonStart.Enabled = !timer.Enabled;
            buttonStop.Enabled = timer.Enabled;

            notifyIconTray.Icon = timer.Enabled ? Properties.Resources.green_icon : Properties.Resources.grey_icon;
            this.Icon = notifyIconTray.Icon;
        }

        internal void UpdateServesComboBox() {
            comboBoxServers.Items.Clear();
            foreach (Server _server in storage.servers) {
                comboBoxServers.Items.Add(_server);
            }
        }

        private void CollectNewUptimeData() {
            foreach (Server _server in this.storage.servers) {
                _server.isAvailable = Helper.ServerIsAvailable(_server.host);
                if (_server.enabled) {
                    if (!_server.isAvailable) continue;
                    if (_server.sshClient == null) _server.InitSshClient();
                    UptimeResult uptimeResult = _server.GetUptimeResult();
                    if (_server.updateResults == null) {
                        _server.updateResults = new List<UptimeResult>();
                    }
                    _server.updateResults.Add(uptimeResult);
                }
            }
        }

        private void UpdateChart() {
            chartServers.Series.Clear();

            List<double> loadAvereageMaximums = new List<double>();
            List<double> epocheMaximums = new List<double>();
            List<double> epocheMinimums = new List<double>();

            chartServers.Series.Clear();

            foreach (Server _server in storage.servers) {
                if (_server.enabled) {
                    if (!_server.isAvailable) continue;
                    Series _series = new Series(_server.name);
                    _series.ChartType = SeriesChartType.Spline;
                    _series.IsXValueIndexed = false;
                    _series.BorderWidth = 2;
                    List<DataPoint> _points = _server.GetLastPoints(Int32.Parse(storage.GetOption(ChartRange)));

                    TimeSpan optionOverloadOptionPeriod = new TimeSpan(0, Int32.Parse(this.storage.GetOption(MainForm.OverloadAlertPeriodMinutes)), 0);

                    if (this.storage.GetOption(MainForm.AlertOnOverload) == "1" && 
                        _points[_points.Count - 1].YValues[0] >= Double.Parse(this.storage.GetOption(MainForm.OverloadValue)) && 
                        DateTime.Now - this.lastOverloadAlertDateTimeMoment > optionOverloadOptionPeriod) {
                            notifyIconTray.BalloonTipIcon = ToolTipIcon.Warning;
                            notifyIconTray.BalloonTipText = String.Format("Load average is {0}", _points[_points.Count - 1].YValues[0].ToString());
                            notifyIconTray.BalloonTipTitle = String.Format("[{0}] Alert!", _server.host);
                            notifyIconTray.ShowBalloonTip(Int32.Parse(this.storage.GetOption(MainForm.OverloadAlertBalloonIntervalToShowSecond)));
                    }

                    epocheMinimums.Add((double)(from DataPoint _point in _points select _point.XValue).Min());
                    epocheMaximums.Add((double)(from DataPoint _point in _points select _point.XValue).Max());
                    loadAvereageMaximums.Add((double)(from DataPoint _point in _points select _point.YValues[0]).Max());
                    foreach (DataPoint _point in _points) {
                        _series.Points.Add(_point);
                    }

                    chartServers.Series.Add(_series);
                }
            }

            chartServers.ChartAreas["ChartAreaServersLA"].Axes[0].Minimum = (double)(from double _data in epocheMinimums select _data).Min();
            chartServers.ChartAreas["ChartAreaServersLA"].Axes[0].Maximum = (double)(from double _data in epocheMaximums select _data).Max();
            chartServers.ChartAreas["ChartAreaServersLA"].Axes[1].Maximum = (double)(from double _data in loadAvereageMaximums select _data).Max() + 1;

            if (chartServers.Legends.FindByName("Servers") == null) {
                chartServers.Legends.Add(new Legend("Servers") { Title = "Servers" });
            }
        }

        #region Options and servers
        private void LoadOptions() {
            List<Option> _options = (List<Option>)this.DeserializeFromXml(this.dataStorageFileNameOptions, typeof(List<Option>));
            this.storage.options = new List<Option>();
            foreach (Option _option in _options) {
                this.storage.options.Add(new Option(_option.key, this.cryptor.Decrypt(_option.value)));
            }
        }

        private void LoadServers() {
            List<Server> _servers = (List<Server>)this.DeserializeFromXml(this.dataStorageFileNameServers, typeof(List<Server>));

            this.storage.servers = new List<Server>();

            foreach (Server _server in _servers) {
                this.storage.servers.Add(new Server(
                        _server.name,
                        _server.host,
                        this.cryptor.Decrypt(_server.userLogin),
                        this.cryptor.Decrypt(_server.userPassword),
                        _server.enabled
                    ));
            }
        }

        private void GenerateDefaultOptions() {
            this.storage.AddOption(TimerInterval, "5000");
            this.storage.AddOption(StartTimerOnLoad, "0");
            this.storage.AddOption(ChartRange, "20");
            this.storage.AddOption(OverloadValue, "100");
            this.storage.AddOption(AlertOnOverload, "0");
            this.storage.AddOption(OverloadAlertPeriodMinutes, "5");
            this.storage.AddOption(OverloadAlertBalloonIntervalToShowSecond, "10");
        }

        private void GenerateDefaultServers() {
            this.storage.servers = new List<Server>();
        }

        internal void SaveOptionsToFile(string fileName = null, List<Option> options = null) {
            if (fileName == null) fileName = this.dataStorageFileNameOptions;
            if (options == null) options = this.storage.options;

            if (options != null || options.Count != 0) {
                List<Option> _options = new List<Option>();

                foreach (Option _option in options) {
                    _options.Add(new Option(_option.key, this.cryptor.Encrypt(_option.value)));
                }

                this.SerializeToXml(_options, fileName);
            }
        }

        internal void SaveServersToFile(string fileName = null, List<Server> servers = null) {
            if (fileName == null) fileName = this.dataStorageFileNameServers;

            if (servers == null) servers = this.storage.servers;

            if (servers != null || servers.Count != 0) {
                List<Server> _servers = new List<Server>();

                foreach (Server _server in servers) {
                    _servers.Add(new Server(
                            _server.name,
                            _server.host,
                            this.cryptor.Encrypt(_server.userLogin),
                            this.cryptor.Encrypt(_server.userPassword),
                            _server.enabled
                        ));
                }

                this.SerializeToXml(_servers, fileName);
            }
        }

        private void SerializeToXml(Object target, string fileName) {
            if (!File.Exists(fileName)) {
                File.Create(fileName).Dispose();
            }

            XmlSerializer xSerializer = new XmlSerializer(target.GetType());

            using (TextWriter tWriter = new StreamWriter(fileName)) {
                xSerializer.Serialize(tWriter, target);
            }

        }

        private object DeserializeFromXml(string fileName, Type t) {
            if (!File.Exists(fileName)) {
                throw new FileNotFoundException();
            }

            XmlSerializer xSerializer = new XmlSerializer(t);

            object list = null;

            using (TextReader tReader = new StreamReader(fileName)) {
                try {
                    list = xSerializer.Deserialize(tReader);
                } catch (InvalidOperationException) {
                    if (fileName == this.dataStorageFileNameOptions) {
                        list = new List<Option>();
                    } else if (fileName == this.dataStorageFileNameServers) {
                        list = new List<Server>();
                    }
                }
            }

            return list;
        }
        #endregion

        #region Form events
        private void timer_Tick(object sender, EventArgs e) {
            toolStripStatusLabelTime.Text = DateTime.Now.ToString();
            if (storage.servers.Count == 0) {
                timer.Stop();
                SetStopStartButtonStatus();
                MessageBox.Show("List of your servers is empty\n");
                return;
            }

            if (!backgroundWorkerForServers.IsBusy) {
                backgroundWorkerForServers.RunWorkerAsync();
            }
        }

        private void buttonManualUpdate_Click(object sender, EventArgs e) {
            if (!backgroundWorkerForServers.IsBusy) {
                backgroundWorkerForServers.RunWorkerAsync();
            }
        }

        private void remoteServersToolStripMenuItem_Click(object sender, EventArgs e) {
            (new RemoteServers()).ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = backgroundWorkerForCommand.IsBusy;

            this.timer.Stop();
            this.timer.Dispose();

            foreach (Server _server in this.storage.servers) {
                _server.UnInitSshClient();
            }

            this.SaveOptionsToFile();
            this.SaveServersToFile();
        }

        private void preToolStripMenuItem_Click(object sender, EventArgs e) {
            (new OptionsForm()).ShowDialog();
        }

        private void buttonStart_Click(object sender, EventArgs e) {
            timer.Start();
            SetStopStartButtonStatus();
        }

        private void buttonStop_Click(object sender, EventArgs e) {
            timer.Stop();
            SetStopStartButtonStatus();
        }

        private void buttonSendCommand_Click(object sender, EventArgs e) {
            Server _selectedServer = comboBoxServers.SelectedItem as Server;
            if (textBoxCommand.Text == "") {
                MessageBox.Show("Command is empty");
            } else if (_selectedServer == null) {
                MessageBox.Show("Select server from list or add new server if server list is empty");
            } else {
                if (!backgroundWorkerForCommand.IsBusy) {
                    Dictionary<string, object> _argument = new Dictionary<string, object>();
                    _argument.Add("server", (object)_selectedServer);
                    _argument.Add("command", (object)textBoxCommand.Text.Trim());
                    backgroundWorkerForCommand.RunWorkerAsync(_argument as object);
                } else {
                    if (MessageBox.Show("Console is busy\nAre you want stop?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK) {
                        _selectedServer.sshClient.Dispose();
                        backgroundWorkerForCommand.CancelAsync();
                        backgroundWorkerForCommand.Dispose();
                    }
                }
            }
        }

        private void textBoxCommand_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                buttonSendCommand_Click(null, null);
            }
        }

        private void richTextBoxLog_TextChanged(object sender, EventArgs e) {
            richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
            richTextBoxLog.ScrollToCaret();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBoxLog.Clear();
        }

        private void MainForm_Resize(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                //notifyIconTray.Visible = true;
                this.Hide();
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Show();
            this.BringToFront();
            this.WindowState = FormWindowState.Normal;
            //notifyIconTray.Visible = false;
        }
        #endregion

    }
}