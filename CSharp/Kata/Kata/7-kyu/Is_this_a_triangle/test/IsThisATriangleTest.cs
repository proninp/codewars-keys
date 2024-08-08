using Kata._7_kyu.Is_this_a_triangle.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.Is_this_a_triangle.test
{
    [TestFixture]
    public class IsThisATriangleTest
    {
        [Test]
        public void IsTriangle_ValidPostiveNumbers_ReturnsTrue()
        {
            ClassicAssert.IsTrue(IsThisATriangle.IsTriangle(5, 7, 10));
        }
    }
}