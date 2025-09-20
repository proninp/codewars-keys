using Kata._7_kyu.Number__to_Letters.src;
using NUnit.Framework;

namespace Kata._7_kyu.Number__to_Letters.test;

[TestFixture]
public class Numbers_To_LettersTest
{
    [Test, Order(1)]
    public void ExampleTest1()
    {
        string expected = "codewars";
        string actual = Numbers_To_Letters.Switcher(
            ["24", "12", "23", "22", "4", "26", "9", "8"]);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, Order(2)]
    public void ExampleTest2()
    {
        string expected = "btswmdsbd kkw";
        string actual = Numbers_To_Letters.Switcher(
            ["25", "7", "8", "4", "14", "23", "8", "25", "23", "29", "16", "16", "4"]);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, Order(3)]
    public void ExampleTest3()
    {
        string expected = "wc";
        string actual = Numbers_To_Letters.Switcher(["4", "24"]);
        Assert.That(actual, Is.EqualTo(expected));
    }
}
