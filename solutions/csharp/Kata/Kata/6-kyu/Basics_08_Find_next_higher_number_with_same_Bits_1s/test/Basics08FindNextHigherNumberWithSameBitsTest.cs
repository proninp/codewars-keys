using Kata._6_kyu.Basics_08_Find_next_higher_number_with_same_Bits_1s.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.Basics_08_Find_next_higher_number_with_same_Bits_1s.test
{
    [TestFixture]
    public class Basics08FindNextHigherNumberWithSameBitsTest
    {
        [TestCase(1, 2)]
        [TestCase(128, 256)]
        [TestCase(127, 191)]
        [TestCase(1022, 1279)]
        [TestCase(1253343, 1253359)]
        [TestCase(201326592, 268435457)]
        [TestCase(805306367, 939524095)]
        public void BasicTests(int n, int expected)
        {
            DoTest(n, expected);
        }

        private void DoTest(int n, int expected)
        {
            int actual = Basics08FindNextHigherNumberWithSameBits.NextHigher(n);
            ClassicAssert.AreEqual(expected, actual);
        }
    }
}