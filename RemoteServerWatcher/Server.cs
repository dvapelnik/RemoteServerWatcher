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

        internal List<UptimeResult> updateResults;

        internal Renci.SshNet.SshClient sshClient;

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

        public static Server GetSeverByName(string name) {
            throw new Exception();
        }

        public static void AddServer(Server server) {
            throw new Exception();
        }

        public static string[] GetServerNames() {
            throw new Exception();
        }

        internal void InitSshClient() {
            this.sshClient = new Renci.SshNet.SshClient(this.host, this.userLogin, this.userPassword);
            this.sshClient.Connect();
        }

        internal void UnInitSshClient() {
            if (this.sshClient != null) {
                this.sshClient.Disconnect();
                this.sshClient.Dispose();
            }
        }

        internal string GetCommandResult(string command) {
            Renci.SshNet.SshCommand cmd = this.sshClient.CreateCommand(command);
            return cmd.Execute();
        }

        internal double[] GetLoadAverage() {
            return (new UptimeResult(this.host, this.GetCommandResult("uptime").Trim("\n".ToCharArray()))).loadAverage;
        }

        internal UptimeResult GetUptimeResult() {
            return new UptimeResult(this.host, this.GetCommandResult("uptime").Trim("\n".ToCharArray()));
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
