using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteServerWatcher {
    internal class UptimeResult {
        DateTime currentDateTime;
        internal string time;
        internal int uptimeDays;
        internal int userCount;
        internal double[] loadAverage;
        internal string hostName;

        internal UptimeResult(string hostName, string uptimeResult) {
            string[] splitted = uptimeResult.Trim().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            this.hostName = hostName;
            this.currentDateTime = DateTime.Now;
            this.time = splitted[0];
            this.uptimeDays = Int32.Parse(splitted[2]);
            this.userCount = Int32.Parse(splitted[5]);
            this.loadAverage = new double[]{
                Double.Parse(splitted[9].Replace('.', ',').Trim(", \n".ToCharArray())),
                Double.Parse(splitted[10].Replace('.', ',').Trim(", \n".ToCharArray())),
                Double.Parse(splitted[11].Replace('.', ',').Trim(", \n".ToCharArray()))
            };
        }

        public override string ToString() {
            return String.Format("Server ({0}) in {1} status: server time - {2}, uptime (days) - {3}, users online - {4}, load average - {5}",
                this.hostName, this.currentDateTime, time, uptimeDays, userCount, String.Join(", ", loadAverage)
            );
        }
    }
}
