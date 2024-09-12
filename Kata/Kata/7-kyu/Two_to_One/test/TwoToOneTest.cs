using Kata._7_kyu.Two_to_One.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.Two_to_One.test;
[TestFixture]
public static class TwoToOneTest
{

    [Test]
    public static void test1()
    {
        ClassicAssert.AreEqual("aehrsty", TwoToOne.Longest("aretheyhere", "yestheyarehere"));
        ClassicAssert.AreEqual("abcdefghilnoprstu", TwoToOne.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
        ClassicAssert.AreEqual("acefghilmnoprstuy", TwoToOne.Longest("inmanylanguages", "theresapairoffunctions"));
    }
}