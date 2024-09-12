using Kata._6_kyu.Are_we_alternate.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.Are_we_alternate.test;

[TestFixture]
public class Test
{
    [Test]
    public void BasicTests()
    {
        ClassicAssert.AreEqual(false, AreWeAlternate.IsAlt("apple"));
        ClassicAssert.AreEqual(true,  AreWeAlternate.IsAlt("banana"));
        ClassicAssert.AreEqual(true,  AreWeAlternate.IsAlt("amazon"));
    }
}