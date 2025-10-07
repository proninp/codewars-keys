using Kata._6_kyu.Sum_of_Digits_Digital_Root.src;
using Kata._6_kyu.Sum_Of_Groups.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Numerics;

namespace Kata._6_kyu.Sum_Of_Groups.test;

[TestFixture]
public class SumOfGroupsTest
{
    [Test]
    public void ExampleTest1()
    {
        var numbers = new BigInteger[] { 1234, 3142, 66654, 65466, 2143 };
        var result = SumOfGroups.SumOfDigitGroups(numbers);
        ClassicAssert.AreEqual(19, result);
    }

    [Test]
    public void ExampleTest2()
    {
        var numbers = new BigInteger[] { 12345, 54321, 98765, 56789, 12354, 54312 };
        var result = SumOfGroups.SumOfDigitGroups(numbers);
        ClassicAssert.AreEqual(23, result);
    }

    [Test]
    public void ExampleTest3()
    {
        var numbers = new BigInteger[] { 111, 11, 1, 222, 22, 2 };
        var result = SumOfGroups.SumOfDigitGroups(numbers);
        ClassicAssert.AreEqual(0, result);
    }

    [TestCase(new [] {10235, 12350, 12356 }, 11)]
    [TestCase(new[] { 12345 }, 0)]
    [TestCase(new[] { 12345, 123450 }, 0)]
    [TestCase(new int[0], 0)]
    [TestCase(new[] { 123, 123, 123, 124, 125, 122 }, 6)]
    public void MyTests(int[] numbers, int expected)
    {
        var bints = numbers.Select(n => new BigInteger(n)).ToArray();
        var actual = SumOfGroups.SumOfDigitGroups(bints);
        ClassicAssert.AreEqual(expected, actual);
    }

    [Test]
    public void TestLargeNumbers()
    {
        var numbers = new BigInteger[] { 9876543210L, 1234567890L, 87654321L, 12345678L };
        var result = SumOfGroups.SumOfDigitGroups(numbers);
        var expected = 45;
        ClassicAssert.AreEqual(expected, result);
    }

}