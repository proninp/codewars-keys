using Kata._8_kyu.Super_Duper_Easy.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;

namespace Kata._8_kyu.Super_Duper_Easy.test
{
    public class SuperDuperEasyTest
    {
        [Test]
        public void ProblemTest()
        {
            ClassicAssert.AreEqual("Error", SuperDuperEasy.Problem("hello"));
            ClassicAssert.AreEqual("56", SuperDuperEasy.Problem("1"));
            ClassicAssert.AreEqual("256", SuperDuperEasy.Problem("5"));
            ClassicAssert.AreEqual("6", SuperDuperEasy.Problem("0"));
            ClassicAssert.AreEqual("66", SuperDuperEasy.Problem("1.2"));
        }

        [Test]
        public void Randoms()
        {
            var i = 0;
            var rand = new Random();
            while (i < 50)
            {
                var num = rand.Next(0, i + 1);
                var expected = (num * 50 + 6).ToString();
                ClassicAssert.AreEqual(expected, SuperDuperEasy.Problem(num.ToString()));
                i++;
            }
        }
    }
}
