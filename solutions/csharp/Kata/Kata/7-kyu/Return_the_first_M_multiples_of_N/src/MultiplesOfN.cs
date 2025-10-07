using System.Linq;

namespace Kata._7_kyu.Return_the_first_M_multiples_of_N.src;
public class MultiplesOfN
{
    public static double[] Multiples(int m, double n)
    {
        return Enumerable.Range(1, m).Select(i => i * n).ToArray();
    }
}