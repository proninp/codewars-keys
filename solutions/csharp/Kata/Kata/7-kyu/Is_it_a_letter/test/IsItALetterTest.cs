using Kata._7_kyu.Is_it_a_letter.src;
using NUnit.Framework;
using System;
using System.Text.RegularExpressions;

namespace Kata._7_kyu.Is_it_a_letter.test
{
    [TestFixture]
    public class IsItALetterTest
    {
        private static Random rnd = new Random();

        [TestCase('a', ExpectedResult = true)]
        [TestCase('1', ExpectedResult = false)]
        public bool Sample_Cases(char c) => IsItALetter.IsItLetter(c);

        [Test]
        public void Random_Cases()
        {
            for (int i = 0; i < 100; i++)
            {
                char c = (char)rnd.Next(32, 137);
                var actual = IsItALetter.IsItLetter(c);
                var expected = new Regex(@"[a-zA-Z]").IsMatch("" + c);
                Assert.That(actual, Is.EqualTo(expected), $"character => \"{c}\"");
            }
        }
    }
}
