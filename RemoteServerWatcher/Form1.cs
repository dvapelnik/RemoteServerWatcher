using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Windows.Forms.DataVisualization.Charting;

namespace RemoteServerWatcher {
    public partial class MainForm : Form {
        private string dataStorageFileNameOptions = "settings.xml";
        private string dataStorageFileNameServers = "servers.xml";

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

            this.timer = new Timer() { Interval = Int32.Parse(this.storage.GetOption("timer-interval-seconds"))};
            this.timer.Tick += timer_Tick;
            if (this.storage.GetOption("start-timer-on-load") == "1") {
                this.timer.Start();
            }

            SetStopStartButtonStatus();
        }

        private void SetStopStartButtonStatus() {
            buttonStart.Enabled = !timer.Enabled;
            buttonStop.Enabled = timer.Enabled;
        }

        void timer_Tick(object sender, EventArgs e) {
            labelTime.Text = DateTime.Now.ToString();
            foreach (Server _server in this.storage.servers) {
                if (!_server.enabled) continue;
                if (_server.sshClient == null) _server.InitSshClient();
                richTextBoxLog.Text = _server.GetUptimeResult().ToString() + "\n" + richTextBoxLog.Text;
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
            this.storage.AddOption("salt", "some-salt-for-test");
            this.storage.AddOption("timer-interval-seconds", "5000");
            this.storage.AddOption("start-timer-on-load", "0");
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
        private void remoteServersToolStripMenuItem_Click(object sender, EventArgs e) {
            (new RemoteServers()).ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
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
        #endregion
    }
}