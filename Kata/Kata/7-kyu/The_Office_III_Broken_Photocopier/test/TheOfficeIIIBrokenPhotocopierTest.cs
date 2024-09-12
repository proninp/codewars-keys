using System;
using System.Linq;
using Kata._7_kyu.The_Office_III_Broken_Photocopier.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.The_Office_III_Broken_Photocopier.test
{
    [TestFixture]
    public class TheOfficeIIIBrokenPhotocopierTest
    {
        [Test]
        public void BasicTests()
        {
            ClassicAssert.AreEqual("0", TheOfficeIIIBrokenPhotocopier.Broken("1"));
            ClassicAssert.AreEqual("01111111010010000001100110111", TheOfficeIIIBrokenPhotocopier.Broken("10000000101101111110011001000"));
            ClassicAssert.AreEqual("011101", TheOfficeIIIBrokenPhotocopier.Broken("100010"));
        }

        [Test]
        public void RandomTests()
        {
            var rand = new Random();

            for (var i = 0; i < 100; i++)
            {
                var len = rand.Next(1, 35);
                var x = String.Concat(Enumerable.Range(0, len).Select(a => rand.Next(0, 2).ToString()));
                var expected = string.Concat(x.Select(a => a == '0' ? '1' : '0'));
                ClassicAssert.AreEqual(expected, TheOfficeIIIBrokenPhotocopier.Broken(x));
            }
        }
    }
}