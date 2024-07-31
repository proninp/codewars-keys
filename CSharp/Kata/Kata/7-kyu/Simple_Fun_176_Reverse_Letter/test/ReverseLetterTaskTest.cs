using System;
using System.Collections.Generic;
using Kata._7_kyu.Simple_Fun_176._Reverse_Letter.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.Simple_Fun_176_Reverse_Letter.test
{
    [TestFixture]
    public class ReverseLetterTaskTest
    {
        public string An(string str)
        {
            var r = "";
            foreach (char c in str) if (c > 96 && c < 123) r = c + r;
            return r;
        }
        public string RndTest()
        {
            string letter = "abcdefghijklmnopqrstuvwxyz", other = "0123456789_ !@#$%^&*_(),.?|{}[]-=+\\/";
            int len = Rand(3, 50), change = Rand(0, len / 2);
            var r = new List<char>();
            for (int i = 0; i < len; i++) r.Add(letter[Rand(0, letter.Length - 1)]);
            while (change-- > 0) r[Rand(0, r.Count - 1)] = other[Rand(0, other.Length - 1)];
            return string.Join("", r);
        }
        Random rndnum = new Random(unchecked((int)DateTime.Now.Ticks));
        public int Rand(int a, int b)
        {
            return a > b ? Rand(b, a) : rndnum.Next(a, b + 1);
        }
        public string Rnds(int n)
        {
            var len = n;
            var rs = new List<char>();
            for (int i = 0; i < len; i++) rs.Add(RndCl());
            return string.Join("", rs);
        }
        public char RndCl()
        {
            var allc = "abcdefghijklmnopqrstuvwxyz";
            return allc[Rand(0, allc.Length - 1)];
        }
        [Test]
        public void Test1__Basic_Tests()
        {
            var kata = new ReverseLetterTask();
            var passed = "Test Passed!\n";

            ClassicAssert.AreEqual("nahsirk", kata.ReverseLetter("krishan"));
            Console.WriteLine(passed);
            ClassicAssert.AreEqual("nortlu", kata.ReverseLetter("ultr53o?n"));
            Console.WriteLine(passed);
            ClassicAssert.AreEqual("cba", kata.ReverseLetter("ab23c"));
            Console.WriteLine(passed);
            ClassicAssert.AreEqual("nahsirk", kata.ReverseLetter("krish21an"));
            Console.WriteLine(passed);
            Console.WriteLine(" ");

        }

        [Test]
        public void Test2__100_Random_Tests()
        {
            var kata = new ReverseLetterTask();

            for (int i = 0; i < 100; i++)
            {
                var ab = RndTest();
                Console.WriteLine("Testing for: " + "\nstr = \"" + ab + "\"");
                var answer = An(ab);
                ClassicAssert.AreEqual(answer, kata.ReverseLetter(ab));
                Console.WriteLine("Pass Value = \"" + answer + "\"\n");
                Console.WriteLine(" ");
            }
        }
    }
}