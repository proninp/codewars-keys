using System;
using Kata._6_kyu.WeIrD_StRiNg_CaSe.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.WeIrD_StRiNg_CaSe.test
{
    [TestFixture]
public class WeIrDStRiNgCaSeTest
{
    private static void DoTest(String input, String expected)
    {
        string actual = WeIrDStRiNgCaSe.ToWeirdCase(input);
        ClassicAssert.AreEqual(expected, actual, "for input: \"" + input + "\"\n");
    }

    [Test]
    public static void ShouldWorkForSomeExamples()
    {
      DoTest("This", "ThIs");
      DoTest("is", "Is");
      DoTest("This is a test", "ThIs Is A TeSt");
    }
}
}