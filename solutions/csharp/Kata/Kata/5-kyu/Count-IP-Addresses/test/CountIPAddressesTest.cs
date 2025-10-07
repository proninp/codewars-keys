using Kata._5_kyu.Count_IP_Addresses.src;
using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._5_kyu.Count_IP_Addresses.test
{
    public class CountIPAddressesTest
    {
        [Test]
        public void FixedTest()
        {
            ClassicAssert.AreEqual(50L, CountIPAddresses.IpsBetween("10.0.0.0", "10.0.0.50"));
            ClassicAssert.AreEqual(246L, CountIPAddresses.IpsBetween("20.0.0.10", "20.0.1.0"));
            ClassicAssert.AreEqual(1L, CountIPAddresses.IpsBetween("150.0.0.0", "150.0.0.1"));
            ClassicAssert.AreEqual(50, CountIPAddresses.IpsBetween("10.0.0.0", "10.0.0.50"));
            ClassicAssert.AreEqual(246, CountIPAddresses.IpsBetween("20.0.0.10", "20.0.1.0"));
            ClassicAssert.AreEqual(243, CountIPAddresses.IpsBetween("10.11.12.13", "10.11.13.0"));
            ClassicAssert.AreEqual(256, CountIPAddresses.IpsBetween("160.0.0.0", "160.0.1.0"));
            ClassicAssert.AreEqual(65536, CountIPAddresses.IpsBetween("170.0.0.0", "170.1.0.0"));
            ClassicAssert.AreEqual(65793, CountIPAddresses.IpsBetween("50.0.0.0", "50.1.1.1"));
            ClassicAssert.AreEqual(16777216, CountIPAddresses.IpsBetween("180.0.0.0", "181.0.0.0"));
            ClassicAssert.AreEqual(67372036, CountIPAddresses.IpsBetween("1.2.3.4", "5.6.7.8"));
            ClassicAssert.AreEqual((1L << 32) - 1L, CountIPAddresses.IpsBetween("0.0.0.0", "255.255.255.255"));
        }
        private Random random = new Random();
        [Test]
        public void RandomTest()
        {
            for (int i = 0; i < 100; i++)
            {
                var a = (long)(random.NextDouble() * (256L * 256L * 256L * 256L - 1));
                var b = (long)(random.NextDouble() * (256L * 256L * 256L)) + 1;
                var c = Math.Min(a + b, 256L * 256L * 256L * 256L - 1);
                var ip1 = IntToIp(a);
                var ip2 = IntToIp(c);
                Console.WriteLine($"IP1: {ip1}, IP2: {ip2}");
                ClassicAssert.AreEqual(c - a, CountIPAddresses.IpsBetween(ip1, ip2));
            }
        }

        private static string IntToIp(long ipInt)
        {
            var sb = new StringBuilder();
            sb.Append((ipInt >> 24) & 0xFF).Append(".");
            sb.Append((ipInt >> 16) & 0xFF).Append(".");
            sb.Append((ipInt >> 8) & 0xFF).Append(".");
            sb.Append(ipInt & 0xFF);
            return sb.ToString();
        }
    }
}