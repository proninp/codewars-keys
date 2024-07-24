using System;
using System.Linq;

namespace Kata._6_kyu.Array_diff
{
    public class Array_diff
    {
        public static int[] ArrayDiff(int[] a, int[] b) =>
            a.Where(e => !b.Contains(e)).ToArray();
    }
}