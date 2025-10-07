using Kata._7_kyu.Highest_and_Lowest.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.Highest_and_Lowest.test
{
    [TestFixture]
    public class HighestAndLowestTest
    {
        [Test]
        public void Test1()
        {
            ClassicAssert.AreEqual("42 -9", HighestAndLowest.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
        [Test]
        public void Test2()
        {
            ClassicAssert.AreEqual("3 1", HighestAndLowest.HighAndLow("1 2 3"));
        }
    }
}