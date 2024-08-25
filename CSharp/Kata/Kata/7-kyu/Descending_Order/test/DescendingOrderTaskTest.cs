using Kata._7_kyu.Descending_Order.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.Descending_Order.test;
[TestFixture]
public class DescendingOrderTaskTest
{
  [Test]
  public void Test0()
  {
    ClassicAssert.AreEqual(0, DescendingOrderTask.DescendingOrder(0));
  }
}