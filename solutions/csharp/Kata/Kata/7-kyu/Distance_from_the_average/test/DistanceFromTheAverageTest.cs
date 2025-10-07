using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kata._7_kyu.Distance_from_the_average.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.Distance_from_the_average.test
{
    [TestFixture]
    public class DistanceFromTheAverageTest
    {
        [Test]
        public void ExampleTests()
        {
            ClassicAssert.AreEqual(new[] { 4.2, -35.8, -2.8, 23.2, 11.2 },
                DistanceFromTheAverage.DistancesFromAverage([55, 95, 62, 36, 48]));
            ClassicAssert.AreEqual(new[] { 0, 0, 0, 0, 0 },
                DistanceFromTheAverage.DistancesFromAverage([1, 1, 1, 1, 1]));
            ClassicAssert.AreEqual(new[] { -1.0, 1.0, -1.0, 1.0, -1.0, 1.0 },
                DistanceFromTheAverage.DistancesFromAverage([1, -1, 1, -1, 1, -1]));
            ClassicAssert.AreEqual(new[] { -0.8, 1.2, -0.8, 1.2, -0.8 },
                DistanceFromTheAverage.DistancesFromAverage([1, -1, 1, -1, 1]));
            ClassicAssert.AreEqual(new[] { -2.0, 2.0 },
                DistanceFromTheAverage.DistancesFromAverage([2, -2]));
            ClassicAssert.AreEqual(new[] { 0 },
                DistanceFromTheAverage.DistancesFromAverage([1]));
            ClassicAssert.AreEqual(new[] { 6197.6, 6385.6, -26111.4, 6673.6, 6854.6 },
                DistanceFromTheAverage.DistancesFromAverage([123, -65, 32432, -353, -534]));
        }
    }
}