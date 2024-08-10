using Kata._6_kyu.Good_vs_Evil.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.Good_vs_Evil.test
{
    [TestFixture]
    public class GoodVsEvilTaskTest
    {
        [Test]
        public static void EvilShouldWin()
        {
            ClassicAssert.AreEqual("Battle Result: Evil eradicates all trace of Good",
                GoodVsEvilTask.GoodVsEvil("1 1 1 1 1 1", "1 1 1 1 1 1 1"));
        }

        [Test]
        public static void GoodShouldTriumph()
        {
            ClassicAssert.AreEqual("Battle Result: Good triumphs over Evil",
                GoodVsEvilTask.GoodVsEvil("0 0 0 0 0 10", "0 1 1 1 1 0 0"));
        }

        [Test]
        public static void ShouldBeATie()
        {
            ClassicAssert.AreEqual("Battle Result: No victor on this battle field",
                GoodVsEvilTask.GoodVsEvil("1 0 0 0 0 0", "1 0 0 0 0 0 0"));
        }
    }
}