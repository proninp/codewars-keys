using Kata._5_kyu.RGB_To_Hex_Conversion.src;
using System;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._5_kyu.RGB_To_Hex_Conversion.test
{
    [TestFixture]
    public class RGBToHexConversionTest
    {
        [Test]
        public void FixedTests()
        {
            ClassicAssert.AreEqual("FFFFFF", RGBToHexConversion.Rgb(255, 255, 255));
            ClassicAssert.AreEqual("FFFFFF", RGBToHexConversion.Rgb(255, 255, 300));
            ClassicAssert.AreEqual("000000", RGBToHexConversion.Rgb(0, 0, 0));
            ClassicAssert.AreEqual("9400D3", RGBToHexConversion.Rgb(148, 0, 211));
            ClassicAssert.AreEqual("9400D3", RGBToHexConversion.Rgb(148, -20, 211), "Handle negative numbers.");
            ClassicAssert.AreEqual("90C3D4", RGBToHexConversion.Rgb(144, 195, 212));
            ClassicAssert.AreEqual("D4350C", RGBToHexConversion.Rgb(212, 53, 12), "Consider single hex digit numbers.");
        }

        private static Random rnd = new Random();

        private static string RGB(int r, int g, int b) => Hex(r) + Hex(g) + Hex(b);

        private static string Hex(int n)
        {
            n = n < 0 ? 0 : n > 255 ? 255 : n;
            return (n < 16 ? "0" : "") + n.ToString("X");
        }

        [Test, Description("Random Tests (100 ClassicAssertions)")]
        public void RandomTest()
        {
            for (int i = 0; i < 100; ++i)
            {
                int r = rnd.Next(-50, 400);
                int g = rnd.Next(-50, 400);
                int b = rnd.Next(-50, 400);
                Console.WriteLine("Testing for {0}, {1}, {2}", r, g, b);

                string expected = RGB(r, g, b);
                string actual = RGBToHexConversion.Rgb(r, g, b);
                ClassicAssert.AreEqual(expected, actual);
            }
        }
    }
}