using Kata._6_kyu.Array_diff.src;
using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.Array_diff.test
{
  [TestFixture]
  public class ArrayDiffTaskTest
  {
    private static Random rnd = new Random();

    private static int[] Solution(int[] a, int[] b)
    {
      HashSet<int> bSet = new HashSet<int>(b);
      return a.Where(v => !bSet.Contains(v)).ToArray();
    }

    [Test]
    public void SampleTest()
    {
      ClassicAssert.AreEqual(new int[] { 2 }, ArrayDiffTask.ArrayDiff([1, 2], [1]));
      ClassicAssert.AreEqual(new int[] { 2, 2 }, ArrayDiffTask.ArrayDiff([1, 2, 2], [1]));
      ClassicAssert.AreEqual(new int[] { 1 }, ArrayDiffTask.ArrayDiff([1, 2, 2], [2]));
      ClassicAssert.AreEqual(new int[] { 1, 2, 2 }, ArrayDiffTask.ArrayDiff([1, 2, 2], []));
      ClassicAssert.AreEqual(new int[] { }, ArrayDiffTask.ArrayDiff([], [1, 2]));
      ClassicAssert.AreEqual(new int[] { 3 }, ArrayDiffTask.ArrayDiff([1, 2, 3], [1, 2]));
    }

    [Test]
    public void RandomTest()
    {
      const int Tests = 300;

      for (int i = 0; i < Tests; ++i)
      {
        int[] a = new int[rnd.Next(0, 10000)].Select(_ => rnd.Next(0, 1001)).ToArray();
        int[] b = new int[rnd.Next(0, 1000)].Select(_ => rnd.Next(0, 1001)).ToArray();

        int[] expected = Solution(a, b);
        int[] actual = ArrayDiffTask.ArrayDiff(a, b);

        ClassicAssert.AreEqual(expected, actual);
      }
    }
  }
}