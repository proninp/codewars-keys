using Kata._6_kyu.Pentabonacci.src;
using NUnit.Framework;

namespace Kata._6_kyu.Pentabonacci.test;

[TestFixture]
public class PentanacciTest
{
    private static void DoTest(long n, long expected)
    {
        var actual = Pentanacci.CountOddPentaFib(n);
        var msg = $"CountOddPentaFib({n}) should return {expected}";
        Assert.That(actual, Is.EqualTo(expected), msg);
    }

    [Test, Order(1)]
    public static void BasicTests()
    {
        DoTest(5, 1);
        DoTest(10, 3);
        DoTest(15, 5);
        DoTest(45, 15);
        DoTest(68, 23);
        DoTest(76, 25);
        DoTest(100, 33);
        DoTest(121, 40);
    }
    
    [Test, Order(2)]
    public static void EdgeCaseTests() {
        DoTest(0, 0);
        DoTest(1, 1);
        DoTest(2, 1);
    }
}