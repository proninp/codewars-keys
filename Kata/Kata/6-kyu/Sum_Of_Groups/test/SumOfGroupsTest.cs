using Kata._6_kyu.Sum_Of_Groups.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;
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

}