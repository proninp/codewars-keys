using Kata._7_kyu.No_oddities_here.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.No_oddities_here.test;
[TestFixture]
public class NoOdditiesHereTest
{
    [Test]
    public void OneThroughFive()
    {
        ClassicAssert.AreEqual(new int[] { 2, 4 }, NoOdditiesHere.NoOdds(new int[] { 1, 2, 3, 4, 5 }));
    }
}