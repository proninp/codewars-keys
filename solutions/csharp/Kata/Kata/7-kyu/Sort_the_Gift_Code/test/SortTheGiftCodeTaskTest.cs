using System;
using System.Linq;
using Kata._7_kyu.Sort_the_Gift_Code.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.Sort_the_Gift_Code.test
{
    [TestFixture]
    public class SortTheGiftCodeTaskTest
    {
        [Test]
        public void SampleTest()
        {
            ClassicAssert.AreEqual("abcdef", SortTheGiftCodeTask.SortGiftCode("abcdef"));
            ClassicAssert.AreEqual("kpqsuvy", SortTheGiftCodeTask.SortGiftCode("pqksuvy"));
            ClassicAssert.AreEqual("abcdefghijklmnopqrstuvwxyz", SortTheGiftCodeTask.SortGiftCode("zyxwvutsrqponmlkjihgfedcba"));
        }

        private static Random rnd = new Random();

        [Test]
        public void RandomTest()
        {
            const int testsCount = 100;

            for (int i = 0; i < testsCount; ++i)
            {
                string test = string.Concat(new char[rnd.Next(6, 40)].Select(_ => (char)rnd.Next(97, 123)).Distinct());

                string expected = string.Concat(test.OrderBy(x => x));
                string actual = SortTheGiftCodeTask.SortGiftCode(test);

                ClassicAssert.AreEqual(expected, actual);
            }
        }
    }
}