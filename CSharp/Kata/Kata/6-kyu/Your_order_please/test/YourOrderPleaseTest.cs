using Kata._6_kyu.Your_order_please.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.Your_order_please.test;
[TestFixture]
public class YourOrderPleaseTest
{
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        ClassicAssert.AreEqual("Thi1s is2 3a T4est", YourOrderPlease.Order("is2 Thi1s T4est 3a"));
        ClassicAssert.AreEqual("Fo1r the2 g3ood 4of th5e pe6ople", YourOrderPlease.Order("4of Fo1r pe6ople g3ood th5e the2"));
        ClassicAssert.AreEqual("", YourOrderPlease.Order(""));
    }
}