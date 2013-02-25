using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace RemoteServerWatcher {
    public partial class MainForm : Form {
        private string dataStorageFileNameOptions = "settings.xml";
        private string dataStorageFileNameServers = "servers.xml";

        public DataProtectionScope scope;
        private Cryptor cryptor;

        internal Storage storage = null;

        public MainForm() {
            this.Name = "MainForm";
            this.scope = DataProtectionScope.CurrentUser;
            this.cryptor = new Cryptor(this.scope);
            this.storage = new Storage();
            if (!File.Exists(this.dataStorageFileNameOptions)) {
                this.GenerateDefaultOptions();
                this.SaveOptionsToFile(this.dataStorageFileNameOptions, this.storage.options);
            }
            if (!File.Exists(this.dataStorageFileNameServers)) {
                this.GenerateDefaultServers();
                this.SaveServersToFile(this.dataStorageFileNameServers, this.storage.servers);
            }

            this.LoadOptions();
            this.LoadServers();
            InitializeComponent();
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
            //create empty data storage file with default options
            this.storage.AddOption("salt", "some-salt-for-test");
            //throw new NotImplementedException();
        }

        private void GenerateDefaultServers() {
            this.storage.servers = new List<Server>();
        }

        private void SaveOptionsToFile(string fileName, List<Option> options) {
            if (options != null || options.Count != 0) {
                List<Option> _options = new List<Option>();

                foreach (Option _option in options) {
                    _options.Add(new Option(_option.key, this.cryptor.Encrypt(_option.value)));
                }

                this.SerializeToXml(_options, fileName);
            }
        }

        private void SaveServersToFile(string fileName, List<Server> servers) {
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
        #endregion
    }
}