using Kata._6_kyu.Split_Strings.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.Split_Strings.test
{
    [TestFixture]
    public class SplitStringsTest
    {
        [Test]
        public void BasicTests()
        {
            ClassicAssert.AreEqual(new string[] { "ab", "c_" }, SplitStrings.Solution("abc"));
            ClassicAssert.AreEqual(new string[] { "ab", "cd", "ef" }, SplitStrings.Solution("abcdef"));
        }
    }
}