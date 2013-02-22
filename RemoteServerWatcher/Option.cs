using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace RemoteServerWatcher {
    [Serializable]
    public class Option {
        public string key;

        public string value;

        public Option() { }

        public Option(string key, string value) {
            if (String.IsNullOrEmpty(key)) throw new ArgumentNullException("Key is null or empty");
            if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("Value is null or empty");
            this.key = key;
            this.value = value;
        }
    }
}
