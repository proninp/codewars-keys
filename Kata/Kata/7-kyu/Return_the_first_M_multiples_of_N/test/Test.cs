using Kata._7_kyu.Return_the_first_M_multiples_of_N.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.Return_the_first_M_multiples_of_N.test;

[TestFixture]
public class Test
{
    [Test]
    public void SampleTests()
    {
        ClassicAssert.AreEqual(new double[] { 5, 10, 15 }, MultiplesOfN.Multiples(3, 5));
    }
}