using System;
using System.Linq;

namespace _6kyu.Simple_Fun_97._Video_Part
{
    public class SimpleFun97VideoPart
    {
        public static int[] VideoPart(string part, string total)
        {
            var totals = total.Split(":").Select(int.Parse).ToArray();
            var totalSec = totals[0] * 60 * 60 + totals[1] * 60 + totals[2];

            var parts = part.Split(":").Select(int.Parse).ToArray();
            var partSec = parts[0] * 60 * 60 + parts[1] * 60 + parts[2];

            int gcd = Gcd(totalSec, partSec);

            return [partSec / gcd, totalSec / gcd];
        }
        private static int Gcd(int a, int b)
        {
            while(a > 0 && b > 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            return Math.Max(a, b);
        }
    }
}
