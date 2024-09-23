using Kata._7_kyu.Find_Maximum_And_Minimum_Values_Of_A_List.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.Find_Maximum_And_Minimum_Values_Of_A_List.test;
[TestFixture]
public class FindMaxAndMinValuesOfAListTest
{
    [Test]
    public void TestExamples()
    {
        ClassicAssert.AreEqual(-110, new FindMaxAndMinValuesOfAList().Min(new[] { -52, 56, 30, 29, -54, 0, -110 }));
        ClassicAssert.AreEqual(0, new FindMaxAndMinValuesOfAList().Min(new[] { 42, 54, 65, 87, 0 }));
        ClassicAssert.AreEqual(566, new FindMaxAndMinValuesOfAList().Max(new[] { 4, 6, 2, 1, 9, 63, -134, 566 }));
        ClassicAssert.AreEqual(5, new FindMaxAndMinValuesOfAList().Max(new[] { 5 }));
    }
}