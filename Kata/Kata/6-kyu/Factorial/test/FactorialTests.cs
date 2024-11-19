using Kata._6_kyu.Factorial.src;
using NUnit.Framework;

namespace Kata._6_kyu.Factorial.test;

[TestFixture]
public class FactorialTests
{
    [Test, Order(1)]
    public void FactorialOf0ShouldBe1()
    {
        Assert.That(FactorialTask.Factorial(0), Is.EqualTo(1));
    }

    [Test, Order(2)]
    public void FactorialOf1ShouldBe1()
    {
        Assert.That(FactorialTask.Factorial(1), Is.EqualTo(1));
    }

    [Test, Order(3)]
    public void FactorialOf2ShouldBe2()
    {
        Assert.That(FactorialTask.Factorial(2), Is.EqualTo(2));
    }

    [Test, Order(4)]
    public void FactorialOf3ShouldBe6()
    {
        Assert.That(FactorialTask.Factorial(3), Is.EqualTo(6));
    }
}
