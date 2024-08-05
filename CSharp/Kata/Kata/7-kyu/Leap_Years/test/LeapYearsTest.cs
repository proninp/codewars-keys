using Kata._7_kyu.Leap_Years.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.Leap_Years.test
{
    [TestFixture]
public static class LeapYearsTest
{
  [Test]
  public static void TestYear2020()
  {
    ClassicAssert.AreEqual(true, LeapYears.IsLeapYear(2020));
  }
  
  [Test]
  public static void TestYear2000()
  {
    ClassicAssert.AreEqual(true, LeapYears.IsLeapYear(2000));
  }
  
  [Test]
  public static void TestYear2015()
  {
    ClassicAssert.AreEqual(false, LeapYears.IsLeapYear(2015));
  }
  
  
  [Test]
  public static void TestYear2100()
  {
    ClassicAssert.AreEqual(false, LeapYears.IsLeapYear(2100));
  }
}
}