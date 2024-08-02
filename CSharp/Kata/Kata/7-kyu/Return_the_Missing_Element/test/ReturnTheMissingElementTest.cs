using Kata._7_kyu.Return_the_Missing_Element.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.Return_the_Missing_Element.test
{
    [TestFixture]
    public class ReturnTheMissingElementTest
    {
        [Test]
        public void EightIsMissing()
        {
            ClassicAssert.AreEqual(8, ReturnTheMissingElement.GetMissingElement([0, 5, 1, 3, 2, 9, 7, 6, 4]));
        }

        [Test]
        public void ThreeIsMissing()
        {
            ClassicAssert.AreEqual(3, ReturnTheMissingElement.GetMissingElement([9, 2, 4, 5, 7, 0, 8, 6, 1]));
        }
    }
}