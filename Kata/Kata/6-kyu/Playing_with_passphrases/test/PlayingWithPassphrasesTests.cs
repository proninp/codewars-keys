using Kata._6_kyu.Playing_with_passphrases.src;
using NUnit.Framework;

namespace Kata._6_kyu.Playing_with_passphrases.test;

[TestFixture]
public class PlayingWithPassphrasesTests
{
    [Test]
    public static void Test1()
    {
        Assert.That(PlayingWithPassphrases.PlayPass("I LOVE YOU!!!", 1), Is.EqualTo("!!!vPz fWpM J"));
    }

    [Test]
    public static void Test2()
    {
        Assert.That(PlayingWithPassphrases.PlayPass("MY GRANMA CAME FROM NY ON THE 23RD OF APRIL 2015", 2), 
            Is.EqualTo("4897 NkTrC Hq fT67 GjV Pq aP OqTh gOcE CoPcTi aO"));
    }
    
    
}