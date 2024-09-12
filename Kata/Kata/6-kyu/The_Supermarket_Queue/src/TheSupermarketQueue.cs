using System;
using System.Linq;

namespace Kata._6_kyu.The_Supermarket_Queue.src
{
    public class TheSupermarketQueue
    {
        public static long QueueTime(int[] customers, int tillsCount)
        {
            if (customers.Length == 0) return 0;
            if (tillsCount == 1) return customers.Sum(x => (long)x);
            if (customers.Length <= tillsCount) return customers.Max();
            var tills = new long[tillsCount];
            foreach (var c in customers)
                tills[Array.IndexOf(tills, tills.Min())] += c;
            return tills.Max();
        }
    }
}