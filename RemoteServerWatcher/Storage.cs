using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;



namespace RemoteServerWatcher {
    public class Storage {
        #region options
        public List<Option> options;

        public bool OptionsIsNullOrEmpty() {
            return (this.options == null || this.options.Count == 0);
        }

        public string GetOption(string key) {
            if (String.IsNullOrEmpty(key)) throw new ArgumentNullException("Argument is empty");
            foreach (Option option in this.options) {
                if (option.key == key) {
                    return option.value;
                }
            }
            return String.Empty;
        }

        public void AddOption(string key, string value) {
            if (String.IsNullOrEmpty(key)) throw new ArgumentNullException("Key is null or empty");
            if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("Value is null or empty");
            if (this.options == null) this.options = new List<Option>();
            this.options.Add(new Option(key, value));
        }

        public void RemoveOption(string key) {
            foreach (Option _option in this.options) {
                if (_option.key == key) {
                    this.options.Remove(_option);
                    break;
                }
            }
        }

        public string[] GetOptionKeys() {
            List<string> _keys = new List<string>();
            foreach (Option _option in this.options) {
                _keys.Add(_option.key);
            }
            return _keys.ToArray();
        }
        #endregion

        #region servers
        public List<Server> servers;

        public bool ServersNullOrEmpty() {
            return (this.servers == null || this.servers.Count == 0);
        }

        public Server GetServer(string host) {
            foreach (Server _server in this.servers) {
                if (_server.host == host) {
                    return _server;
                }
            }
            return null;
        }

        public void AddServer(Server server) {
            if (this.servers == null) {
                this.servers = new List<Server>();
            }

            this.servers.Add(server);
        }

        public void RemoveServer(string host) {
            foreach (Server _server in this.servers) {
                if (_server.host == host) {
                    this.servers.Remove(_server);
                    break;
                }
            }
        }

        public string[] GetHosts() {
            List<string> _hosts = new List<string>();

            foreach (Server _server in this.servers) {
                _hosts.Add(_server.host);
            }

            return _hosts.ToArray();
        }
        #endregion
    }
}
