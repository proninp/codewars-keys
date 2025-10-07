using Kata._6_kyu.Give_me_a_Diamond.src;
using NUnit.Framework;
using System.Text;

namespace Kata._6_kyu.Give_me_a_Diamond.test;

[TestFixture]
public class DiamondTest
{
    [Test, Order(1)]
    public void TestNull()
    {
        Assert.That(Diamond.Print(0), Is.Null);
        Assert.That(Diamond.Print(-2), Is.Null);
        Assert.That(Diamond.Print(2), Is.Null);
    }

    [Test, Order(2)]
    public void TestDiamond1()
    {
        var expected = new StringBuilder();
        expected.Append("*\n");
        Assert.That(Diamond.Print(1), Is.EqualTo(expected.ToString()));
    }

    [Test, Order(3)]
    public void TestDiamond3()
    {
        var expected = new StringBuilder();
        expected.Append(" *\n");
        expected.Append("***\n");
        expected.Append(" *\n");

        var actual = Diamond.Print(3);

        Assert.That(Diamond.Print(3), Is.EqualTo(expected.ToString()));
    }

    [Test, Order(4)]
    public void TestDiamond5()
    {
        var expected = new StringBuilder();
        expected.Append("  *\n");
        expected.Append(" ***\n");
        expected.Append("*****\n");
        expected.Append(" ***\n");
        expected.Append("  *\n");

        Assert.That(Diamond.Print(5), Is.EqualTo(expected.ToString()));
    }
}