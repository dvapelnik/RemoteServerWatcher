using System;
using System.Collections;
using System.Collections.Generic;

namespace RemoteServerWatcher {
    public class Server {
        public string name = String.Empty;
        public string host = String.Empty;
        public string userLogin = String.Empty;
        public string userPassword = String.Empty;
        public bool enabled = false;

        private static List<Server> servers;

        public string getHashedObject() {
            return String.Join(">>", new string[] { this.host, this.userLogin, this.userPassword, this.enabled ? "1" : "0" });
        }

        public Server() { }

        public Server(string name, string host, string userLogin, string userPassword, bool enabled = true) {
            this.name = name;
            this.host = host;
            this.userLogin = userLogin;
            this.userPassword = userPassword;
            this.enabled = enabled;
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

        public override string ToString() {
            return this.name;
        }
    }

    internal class ServerException : Exception {
        public ServerException(string message)
            : base(message) {
        }
    }
}
