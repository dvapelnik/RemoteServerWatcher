using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace RemoteServerWatcher {
    public partial class MainForm : Form {
        private string dataStorageFileNameOptions = "settings.dat";
        private string dataStorageFileNameServers = "servers.dat";

        public DataProtectionScope scope;

        internal Storage storage = null;

        public MainForm() {
            this.storage = new Storage();
            this.scope = DataProtectionScope.CurrentUser;
            if (!File.Exists(this.dataStorageFileNameOptions)) {
                this.GenerateDefaultOptionsAndSaveOnDisk();
                this.SaveOptionsToFile(this.dataStorageFileNameOptions);
            }
            this.LoadOptions();
            //same code as upper for servers
            InitializeComponent();
        }

        private void SaveOptionsToFile(string fileName) {
            //throw new NotImplementedException();
        }

        private void LoadOptions() {
            //load options in Option.options
            //load servers in Server.servers
            //throw new Exception();
        }

        private void GenerateDefaultOptionsAndSaveOnDisk() {
            //create empty data storage file with default options
            this.storage.AddOption("salt", "some-salt-for-test");
            //throw new NotImplementedException();
        }

        #region Form events
        private void remoteServersToolStripMenuItem_Click(object sender, EventArgs e) {
            (new RemoteServers()).ShowDialog();
        }
        #endregion
    }
}