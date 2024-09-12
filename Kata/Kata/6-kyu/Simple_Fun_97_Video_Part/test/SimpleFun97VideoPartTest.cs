using Kata._6_kyu.Simple_Fun_97_Video_Part.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._6_kyu.Simple_Fun_97_Video_Part.test
{
    [TestFixture]
    public class SimpleFun97VideoPartTest
    {
        public int[] An(string part, string total)
        {
            var t1 = part.Split(':').Select(int.Parse).ToArray();
            var t2 = total.Split(':').Select(int.Parse).ToArray();
            int r1 = t1[0] * 3600 + t1[1] * 60 + t1[2],
                r2 = t2[0] * 3600 + t2[1] * 60 + t2[2],
                g = TestmyGCD(r1, r2);
            return [r1 / g, r2 / g];

        }

        public int TestmyGCD(int a, int b) => b == 0 ? a : TestmyGCD(b, a % b);

        public string[] RndTest()
        {
            int jl = Rand(0, 2),
                h1 = (jl > 0 ? Rand(0, 1) : Rand(0, 10)),
                m1 = Rand(0, 59),
                s1 = Rand(0, 29) * 2,
                h2 = (jl > 0 ? Rand(h1 + 1, 5) : Rand(h1 + 1, 99)),
                m2 = Rand(0, 59),
                s2 = Rand(0, 29) * 2;
            while (h1 + m1 + s1 == 0) { m1 = Rand(0, 59); s1 = Rand(0, 29) * 2; }
            return [Fm(h1) + ":" + Fm(m1) + ":" + Fm(s1), Fm(h2) + ":" + Fm(m2) + ":" + Fm(s2)];

        }

        public string Fm(int n)
        {
            var s = "0" + n;
            return s.Substring(s.Length - 2);
        }

        Random rndm = new Random(unchecked((int)DateTime.Now.Ticks));

        public int Rand(int a, int b) => a > b ? Rand(b, a) : rndm.Next(a, b + 1);

        [Test]
        public void SimpleFun97VideoPartBasicTests1()
        {
            var kata = new SimpleFun97VideoPart();
            var passed = "<font size=2 color='#8FBC8F'>Test Passed!</font>\n";

            ClassicAssert.AreEqual(new int[] { 1, 3 }, kata.VideoPart("02:20:00", "07:00:00"));
            Console.WriteLine(passed);
            ClassicAssert.AreEqual(new int[] { 1, 1 }, kata.VideoPart("25:26:20", "25:26:20"));
            Console.WriteLine(passed);
            ClassicAssert.AreEqual(new int[] { 7, 30 }, kata.VideoPart("00:02:20", "00:10:00"));
            Console.WriteLine(passed);
            Console.WriteLine(" ");

        }

        [Test]
        public void SimpleFun97VideoPartBasicTests2()
        {
            var kata = new SimpleFun97VideoPart();

            for (int i = 0; i < 100; i++)
            {
                var ab = RndTest();
                Console.WriteLine("<font size=2 color='#CFB53B'>Testing for: " +
                "\npart = \"" + ab[0] + "\""
                + "\ntotal = \"" + ab[1] + "\""
                + "</font>");
                var answer = An(ab[0], ab[1]);
                ClassicAssert.AreEqual(answer, kata.VideoPart(ab[0], ab[1]));
                Console.WriteLine("<font size=2 color='#8FBC8F'>" +
                "Pass Value = new int[]{" + string.Join(", ", answer) + "}</font>\n");
                Console.WriteLine(" ");
            }

            Console.WriteLine("<div style='width:360px;background-color:gray'><br><font size=2 color='#3300dd'><b>Happy Coding ^_^</b></font>");
            Console.WriteLine("<br><font size=2 color='#5500ee'><b>Thanks for solve this kata,\nI'm waiting for your:<font color='993300'>\nfeedback, voting and ranking ;-)</b></font></div>");

        }
    }
}
