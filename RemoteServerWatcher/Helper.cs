using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace RemoteServerWatcher {
    class Helper {
        internal static double DateTimeToUnixTimeStamp(DateTime dateTime) {
            DateTime unixEpoche = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
            TimeSpan delta = dateTime - unixEpoche;
            return delta.TotalSeconds;
        }

        internal static T[] GetLastItems<T>(T[] array, int count) {
            return array.Skip(Math.Max(0, array.Length - count)).Take(count).ToArray();
        }

        internal static List<T> GetLastItems<T>(List<T> list, int count) {
            return list.Skip(Math.Max(0, list.Count - count)).Take(count).ToList();
        }

        internal static bool ServerIsAvailable(string serverName, int ttl = 1000) {
            Ping ping = new Ping();
            PingReply replay = ping.Send(serverName, ttl);
            return replay.Status == IPStatus.Success;
        }
    }
}
