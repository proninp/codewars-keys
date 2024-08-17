using System;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.ColorChoice.test
{
    [TestFixture]
    public class ColorChoiceTest
    {

        [Test]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests");
            ClassicAssert.AreEqual(2, src.ColorChoice.Checkchoose(6, 4));
            ClassicAssert.AreEqual(1, src.ColorChoice.Checkchoose(4, 4));
            ClassicAssert.AreEqual(3, src.ColorChoice.Checkchoose(35, 7));
            ClassicAssert.AreEqual(-1, src.ColorChoice.Checkchoose(4, 2));
            ClassicAssert.AreEqual(-1, src.ColorChoice.Checkchoose(36, 7));
        }
    }
}