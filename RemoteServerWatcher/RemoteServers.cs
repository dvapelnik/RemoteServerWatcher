using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using Renci.SshNet;
using Renci.SshNet.Common;

namespace RemoteServerWatcher {
    public partial class RemoteServers : Form {
        public RemoteServers(bool loadOptions = true) {
            InitializeComponent();
            this.UpdateServersInListBox();
        }

        private void UpdateServersInListBox() {
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            if (mainForm.storage.servers.Count != 0) {
                listBoxServers.Items.Clear();
                foreach (Server _server in mainForm.storage.servers) {
                    listBoxServers.Items.Add(_server);
                }
            }
        }

        private void ClearFields(){
            foreach (Control _control in groupBoxMainGroup.Controls) {
                if (_control is TextBox) (_control as TextBox).Clear();
                if (_control is CheckBox) (_control as CheckBox).Checked = true;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void buttonTestConnection_Click(object sender, EventArgs e) {
            if (textBoxHostName.Text.Length == 0 || textBoxLogin.Text.Length == 0 || textBoxPassword.Text.Length == 0) return;
            using (Ping p = new Ping()) {
                try {
                    p.Send(textBoxHostName.Text);
                    using (SshClient sshClientForTest = new SshClient(textBoxHostName.Text, textBoxLogin.Text, textBoxPassword.Text)) {
                        try {
                            sshClientForTest.Connect();
                            MessageBox.Show("Connection success!");
                        } catch (SshAuthenticationException) {
                            MessageBox.Show("Can`t connect to server. Auth error");
                        } catch (Exception) {
                            //MessageBox.Show(exception.GetType().ToString());
                        }
                    }
                } catch (PingException) {
                    MessageBox.Show("Host is unavailable");
                    return;
                } catch (Exception) {
                }
            }

        }

        private void textBoxName_Enter(object sender, EventArgs e) {
            (sender as TextBox).SelectAll();
        }

        private void buttonSaveServer_Click(object sender, EventArgs e) {
            if (textBoxName.Text.Length == 0) {
                textBoxName.Text = textBoxHostName.Text;
            }

            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];

            if (Array.IndexOf(mainForm.storage.GetHosts(), textBoxName.Text) == -1) {
                mainForm.storage.AddServer(new Server(textBoxName.Text, textBoxHostName.Text, textBoxLogin.Text, textBoxPassword.Text));
                UpdateServersInListBox();
                ClearFields();
            } else {
                MessageBox.Show("Server with same name already saved\nChange server name");
            }
        }

        private void listBoxServers_SelectedIndexChanged(object sender, EventArgs e) {
            Server _selectedServer = (sender as ListBox).SelectedItem as Server;
            textBoxName.Text = _selectedServer.name;
            textBoxHostName.Text = _selectedServer.host;
            textBoxLogin.Text = _selectedServer.userLogin;
            textBoxPassword.Text = _selectedServer.userPassword;
        }
    }
}
