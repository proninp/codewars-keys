using Kata._6_kyu.String_average.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.String_average.test
{
    [TestFixture]
    public class StringAverageTest
    {
        [Test]
        public void SampleTests()
        {
            ClassicAssert.AreEqual("four", StringAverage.AverageString("zero nine five two"));
            ClassicAssert.AreEqual("three", StringAverage.AverageString("four six two three"));
            ClassicAssert.AreEqual("three", StringAverage.AverageString("one two three four five"));
            ClassicAssert.AreEqual("four", StringAverage.AverageString("five four"));
            ClassicAssert.AreEqual("zero", StringAverage.AverageString("zero zero zero zero zero"));
            ClassicAssert.AreEqual("two", StringAverage.AverageString("one one eight one"));
            ClassicAssert.AreEqual("n/a", StringAverage.AverageString(""));
        }
    }
}