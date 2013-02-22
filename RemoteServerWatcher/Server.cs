using System;
using System.Collections;
using System.Collections.Generic;

namespace RemoteServerWatcher {
    class Server {
        public string host = String.Empty;
        public string userLogin = String.Empty;
        public string userPassword = String.Empty;
        public bool isEnabled = false;

        private static List<Server> servers;

        public string getHashedObject() {
            return String.Join(">>", new string[] { this.host, this.userLogin, this.userPassword, this.isEnabled ? "1" : "0" });
        }

        public Server(string host, string userLogin, string userPassword) {
            this.host = host;
            this.userLogin = userLogin;
            this.userPassword = userPassword;
        }

        public Server(string hash) {
            string[] _arr = hash.Split(new string[] { ">>" }, StringSplitOptions.RemoveEmptyEntries);
            if (_arr.Length == 4) {
                this.host = _arr[0];
                this.userLogin = _arr[1];
                this.userPassword = _arr[2];
                this.isEnabled = _arr[3] == "1";
            } else {
                throw new ServerException("Parse error");
            }
        }

        public static Server GetSeverByName(string name){
            throw new Exception();
        }

        public static void AddServer(Server server){
            throw new Exception();
        }

        public static string[] GetServerNames(){
            throw new Exception();
        }
    }

    internal class ServerException : Exception {
        public ServerException(string message)
            : base(message) {
        }
    }
}
