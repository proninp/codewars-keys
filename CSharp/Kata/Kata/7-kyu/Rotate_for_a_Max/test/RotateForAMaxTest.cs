using Kata._7_kyu.Rotate_for_a_Max.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.Rotate_for_a_Max.test
{
    [TestFixture]
    public static class RotateForAMaxTest
    {
        [Test]
        public static void TestSamples()
        {
            ClassicAssert.AreEqual(68957, RotateForAMax.MaxRot(56789), "For n = 56789");
            ClassicAssert.AreEqual(85821534, RotateForAMax.MaxRot(38458215), "For n = 38458215");
            ClassicAssert.AreEqual(988103115, RotateForAMax.MaxRot(195881031), "For n = 195881031");
            ClassicAssert.AreEqual(962193428, RotateForAMax.MaxRot(896219342), "For n = 896219342");
            ClassicAssert.AreEqual(94183076, RotateForAMax.MaxRot(69418307), "For n = 69418307");
            ClassicAssert.AreEqual(507992495, RotateForAMax.MaxRot(507992495), "For n = 507992495");
        }
    }
}