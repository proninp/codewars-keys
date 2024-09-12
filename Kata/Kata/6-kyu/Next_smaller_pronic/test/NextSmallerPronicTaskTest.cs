using Kata._6_kyu.Next_smaller_pronic.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.Next_smaller_pronic.test;
[TestFixture]
public class NextSmallerPronicTaskTest
{
  [TestCase(150UL, 132UL)]
  [TestCase(81UL, 72UL)]
  [TestCase(49UL, 42UL)]
  [TestCase(36UL, 30UL)]
  [TestCase(25UL, 20UL)]
  [TestCase(16UL, 12UL)]
  [TestCase(9UL, 6UL)]
  [TestCase(4UL, 2UL)]
  [TestCase(2UL, 0UL)]
  public void FixedTests(ulong x, ulong expected)
  {
    ClassicAssert.AreEqual(expected, NextSmallerPronicTask.NextSmallerPronic(x));
  }
}