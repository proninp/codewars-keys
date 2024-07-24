using System;
using System.Linq;

namespace Kata._7_kyu.Number_Pairs
{
    public class NumberPairs
    {
        public static int[] GetLargerNumbers(int[] a, int[] b)
        {
            return a.Select((x, i) => Math.Max(x, b[i])).ToArray();
        }
    }
}