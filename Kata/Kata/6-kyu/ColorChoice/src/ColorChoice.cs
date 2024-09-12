using System.Numerics;

namespace Kata._6_kyu.ColorChoice.src
{
    public class ColorChoice
    {
        public static long Checkchoose(long m, int n)
        {
            var factorials = new BigInteger[n + 1];
            factorials[0] = 1;
            factorials[1] = 1;
            for (int i = 2; i <= n; i++)
                factorials[i] = factorials[i - 1] * i;
            
            for (int i = 1; i <= n/2; i++)
                if (m == (factorials[n] / (factorials[i] * factorials[n - i])))
                    return i;
            return -1;
        }
    }
}