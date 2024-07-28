using System;
using System.Linq;

namespace Kata._6_kyu.Array_diff.src
{
    public class ArrayDiffTask
    {
        public static int[] ArrayDiff(int[] a, int[] b) =>
            a.Where(e => !b.Contains(e)).ToArray();
    }
}