using Kata._8_kyu.Even_or_Odd.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._8_kyu.Even_or_Odd.test
{
  [TestFixture]
  public class EvenOrOddTaskTest
  {
    [TestCase(1)]
    [TestCase(7)]
    public void PositiveOddTest(int num)
    {
      ClassicAssert.AreEqual("Odd", EvenOrOddTask.EvenOrOdd(num));
    }

    [TestCase(2)]
    [TestCase(42)]
    public void PositiveEvenTest(int num)
    {
      ClassicAssert.AreEqual("Even", EvenOrOddTask.EvenOrOdd(num));
    }

    [TestCase(-1)]
    [TestCase(-7)]
    public void NegativeOddTest(int num)
    {
      ClassicAssert.AreEqual("Odd", EvenOrOddTask.EvenOrOdd(num));
    }

    [TestCase(-2)]
    [TestCase(-42)]
    public void NegativeEvenTest(int num)
    {
      ClassicAssert.AreEqual("Even", EvenOrOddTask.EvenOrOdd(num));
    }

    [Test]
    public void ZeroIsEvenTest()
    {
      ClassicAssert.AreEqual("Even", EvenOrOddTask.EvenOrOdd(0));
    }
  }
}