using System;
using Kata._6_kyu.Jewel_Thief.src;
using NUnit.Framework;

namespace Kata._6_kyu.Jewel_Thief.test;

[TestFixture]
public class JewelThiefTest
{
    [Test]
    public void Test1()
    {
        var random = new Random();
        var expected = random.Next(100_001);
        var combination = "L51-L23-L56";
        var safe = new Safe(combination, expected);

        var actual = JewelThief.Crack(safe);
        Assert.That(actual, Is.EqualTo(expected));
    }

}