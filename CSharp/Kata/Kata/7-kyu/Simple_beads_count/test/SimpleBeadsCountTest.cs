using Kata._7_kyu.Simple_beads_count.src;
using NUnit.Framework;
using System;

namespace Kata._7_kyu.Simple_beads_count.test
{
    public class TestHelpers
    {
        protected Random rnd = new Random();

        protected int solution(int n) => n < 2 ? 0 : n * 2 - 2;
    }

    [TestFixture]
    public class SimpleBeadsCountTest
    {
        [Test, Description("Basic Tests")]
        public void SampleTest()
        {
            Assert.That(SimpleBeadsCount.CountRedBeads(0), Is.EqualTo(0));
            Assert.That(SimpleBeadsCount.CountRedBeads(1), Is.EqualTo(0));
            Assert.That(SimpleBeadsCount.CountRedBeads(3), Is.EqualTo(4));
            Assert.That(SimpleBeadsCount.CountRedBeads(5), Is.EqualTo(8));
        }
    }

    [TestFixture]
    public class RandomTests : TestHelpers
    {
        [Test, Description("Random Tests")]
        public void RandomTest()
        {
            for (int i = 0; i < 100; ++i)
            {
                int testCase = rnd.Next(0, 5000);
                int actual = SimpleBeadsCount.CountRedBeads(testCase);
                int expected = solution(testCase);

                Assert.That(actual, Is.EqualTo(expected), $"Wrong result for n = {testCase}.");
            }
        }
    }
}
