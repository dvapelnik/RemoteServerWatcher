using System;
using System.Windows.Forms;
using Renci.SshNet;
using Renci.SshNet.Common;

namespace RemoteServerWatcher {
    public partial class RemoteServers : Form {
        public RemoteServers(bool loadOptions = true) {
            InitializeComponent();
            textBoxHostName.Focus();
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void buttonTestConnection_Click(object sender, EventArgs e) {
            using (SshClient sshClientForTest = new SshClient(textBoxHostName.Text, textBoxLogin.Text, textBoxPassword.Text)) {
                try {
                    sshClientForTest.Connect();
                    MessageBox.Show("Connection success!");
                }catch(SshAuthenticationException){
                    MessageBox.Show("Can`t connect to server. Auth error");
                } catch (Exception exception) {
                    MessageBox.Show(exception.GetType().ToString());
                }
            }
        }
    }
}
