using Kata._7_kyu.Progressive_Spiral_Number_Position.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.Progressive_Spiral_Number_Position.test;
public class ProgressiveSpiralNumberPositionTest
{
    [Test]
    public void FixedTest()
    {
        ClassicAssert.AreEqual(1L, ProgressiveSpiralNumberPosition.Layers(1));
        ClassicAssert.AreEqual(2L, ProgressiveSpiralNumberPosition.Layers(5));
        ClassicAssert.AreEqual(3L, ProgressiveSpiralNumberPosition.Layers(25));
        ClassicAssert.AreEqual(4L, ProgressiveSpiralNumberPosition.Layers(30));
        ClassicAssert.AreEqual(5L, ProgressiveSpiralNumberPosition.Layers(50));
    }
}