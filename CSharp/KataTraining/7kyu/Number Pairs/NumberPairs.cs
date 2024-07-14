using System;
using System.Linq;

namespace _7kyu.Number_Pairs
{
    public class NumberPairs
    {
        public static int[] GetLargerNumbers(int[] a, int[] b)
        {
            return a.Select((x, i) => Math.Max(x, b[i])).ToArray();
        }
    }
}