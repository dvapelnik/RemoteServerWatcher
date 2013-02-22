using System;
using System.Windows.Forms;

namespace RemoteServerWatcher {
    public partial class RemoteServers : Form {
        public RemoteServers(bool loadOptions = true) {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
