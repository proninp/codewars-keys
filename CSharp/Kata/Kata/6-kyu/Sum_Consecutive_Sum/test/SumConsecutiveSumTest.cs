using Kata._6_kyu.Sum_Consecutive_Sum.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Numerics;

namespace Kata._6_kyu.Sum_Consecutive_Sum.test;
[TestFixture]
public class SumConsecutiveSumTest
{
    [Test]
    public void ExampleTest1()
    {
        var arr = new BigInteger[] { 1, 2, 5, 6, 10, 11, 12 };
        int result = SumConsecutiveSum.ConsecutiveSum(arr);
        ClassicAssert.AreEqual(11, result);
    }

    [Test]
    public void ExampleTest2()
    {
        var arrays = new BigInteger[][]
        {
           new BigInteger[] { 3, 1, 100, 120, 101, 99, 2 },
           new BigInteger[] { 3, 1000, 1005, 1000, 1000, 1000, 6, 7, 1003, 1004, 4, 5, 1002, 8, 9, 1001, 1004 },
           new BigInteger[] { 3, 1000, 1005, 1000, 9999999, 1000, 1000, 6, 7, 1003, 1004, 4, 5, 1002, 8, 9, 1001, 1004 }
        };

        int actual = SumConsecutiveSum.ConsecutiveSum(arrays[0]);
        ClassicAssert.AreEqual(9, actual);
        actual = SumConsecutiveSum.ConsecutiveSum(arrays[1]);
        ClassicAssert.AreEqual(18, actual);
        actual = SumConsecutiveSum.ConsecutiveSum(arrays[2]);
        ClassicAssert.AreEqual(18, actual);
    }

    [Test]
    public void ExampleTest3()
    {
        var large = new BigInteger[][]
        {
            new BigInteger[] {BigInteger.Parse("99999999999999999999999999999999999999999999999999"),BigInteger.Parse("100000000000000000000000000000000000000000000000000"), BigInteger.Parse("100000000000000000000000000000000000000000000000001")},
            new BigInteger[] {BigInteger.Parse("100000000000"),BigInteger.Parse("100000000001"),BigInteger.Parse("100000000002")}
        };

        ClassicAssert.AreEqual(3, SumConsecutiveSum.ConsecutiveSum(large[0]));
        ClassicAssert.AreEqual(6, SumConsecutiveSum.ConsecutiveSum(large[1]));
    }
}
