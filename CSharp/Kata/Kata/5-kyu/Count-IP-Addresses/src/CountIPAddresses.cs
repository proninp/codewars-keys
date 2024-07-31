using System;
using System.Linq;

namespace Kata._5_kyu.Count_IP_Addresses.src
{
    public class CountIPAddresses
    {
        public static long IpsBetween(string start, string end)
        {
            var startIps = start.Split('.').Select(int.Parse).ToArray();
            var endIps = end.Split('.').Select(int.Parse).ToArray();
            var diffIps = startIps.Select((x, i) => endIps[i] - x).ToArray();
            long diff = 0;
            for (var i = startIps.Length - 1; i >= 0; i--)
            {
                int sectionDiff = endIps[i] - startIps[i];
                if (sectionDiff != 0)
                    diff += (long)Math.Pow(256, startIps.Length - 1 - i) * sectionDiff;
            }
            return diff;
        }
    }
}
