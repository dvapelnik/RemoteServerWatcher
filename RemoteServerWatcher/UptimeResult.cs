using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteServerWatcher {
    internal class UptimeResult {
        internal DateTime currentDateTime;
        internal string time = String.Empty;
        internal int uptimeDays = 0;
        internal int userCount = 0;
        internal double[] loadAverage;
        internal string hostName = String.Empty;

        internal UptimeResult(string hostName, string uptimeResult) {
            string[] splitted = uptimeResult.Trim().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            this.currentDateTime = DateTime.Now;

            this.hostName = hostName;
            //this.time = splitted[0];
            //this.uptimeDays = Int32.Parse(splitted[2]);
            //this.userCount = Int32.Parse(splitted[5]);

            string[] loadAverage = Helper.GetLastItems(splitted, 3);

            this.loadAverage = new double[]{
                Double.Parse(loadAverage[0].Replace('.', ',').Trim(", \n".ToCharArray())),
                Double.Parse(loadAverage[1].Replace('.', ',').Trim(", \n".ToCharArray())),
                Double.Parse(loadAverage[2].Replace('.', ',').Trim(", \n".ToCharArray()))
            };
        }

        public override string ToString() {
            return String.Format("Server ({0}) in {1} status: server time - {2}, uptime (days) - {3}, users online - {4}, load average - {5}",
                this.hostName, this.currentDateTime, time, uptimeDays, userCount, String.Join(", ", loadAverage)
            );
        }
    }
}
