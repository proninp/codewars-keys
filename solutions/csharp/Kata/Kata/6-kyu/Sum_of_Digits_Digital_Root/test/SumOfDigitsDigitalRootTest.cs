using Kata._6_kyu.Sum_of_Digits_Digital_Root.src;
using NUnit.Framework;

namespace Kata._6_kyu.Sum_of_Digits_Digital_Root.test;
[TestFixture]
public class SumOfDigitsDigitalRootTest
{
    [TestCase(0, ExpectedResult = 0)]
    [TestCase(10, ExpectedResult = 1)]
    [TestCase(16, ExpectedResult = 7)]
    [TestCase(195, ExpectedResult = 6)]
    [TestCase(992, ExpectedResult = 2)]
    [TestCase(167346, ExpectedResult = 9)]
    [TestCase(999999999999, ExpectedResult = 9)]
    public int Tests(long n)
    {
        return SumOfDigitsDigitalRoot.DigitalRoot(n);
    }
}