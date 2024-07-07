using System;
using System.Linq;

namespace _6kyu.Array.diff
{
    public class Array_diff
    {
        public static int[] ArrayDiff(int[] a, int[] b) =>
            a.Where(e => !b.Contains(e)).ToArray();
    }
}