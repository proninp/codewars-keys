using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kata._6_kyu.Points_in_the_circle.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.Points_in_the_circle.test
{
    [TestFixture]
  public class PointsInTheCircleTest
  {
    [Test]
    public void BasicTests()
    {
      ClassicAssert.AreEqual(5, PointsInTheCircle.PointsNumber(1));
      ClassicAssert.AreEqual(13, PointsInTheCircle.PointsNumber(2));
      ClassicAssert.AreEqual(29, PointsInTheCircle.PointsNumber(3));
      ClassicAssert.AreEqual(81, PointsInTheCircle.PointsNumber(5));
      ClassicAssert.AreEqual(3141549, PointsInTheCircle.PointsNumber(1000));
    }
  }
}