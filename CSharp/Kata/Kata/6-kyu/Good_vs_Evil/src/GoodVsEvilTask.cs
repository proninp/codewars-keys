using System.Linq;

namespace Kata._6_kyu.Good_vs_Evil.src
{
    public class GoodVsEvilTask
    {
        public static string GoodVsEvil(string good, string evil)
        {
            var goodWoth = new int[] {1, 2, 3, 3, 4, 10};
            var evilWoth = new int[] {1, 2, 2, 2, 3, 5, 10};
            
            var gw = good.Split(' ').Select((x, i) => int.Parse(x) * goodWoth[i]).Sum();
            var ew = evil.Split(' ').Select((x, i) => int.Parse(x) * evilWoth[i]).Sum();

            if (gw > ew) return "Battle Result: Good triumphs over Evil";
            if (gw < ew) return "Battle Result: Evil eradicates all trace of Good";
            return "Battle Result: No victor on this battle field";
        }
    }
}