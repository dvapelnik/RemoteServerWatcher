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
        public List<Option> options;
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

        public void LoadOptions(string hash) {
            if (String.IsNullOrEmpty(hash)) throw new ArgumentNullException("Hash is null or empty");
            throw new Exception();
        }

        public void SaveOptions() { 

        }
    }
}
