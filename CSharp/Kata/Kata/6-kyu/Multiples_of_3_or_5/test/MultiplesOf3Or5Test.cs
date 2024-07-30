using System;
using Kata._6_kyu.Multiples_of_3_or_5.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.Multiples_of_3_or_5.test
{
    [TestFixture]
    public class MultiplesOf3Or5Test
    {
        [Test]
        public void SampleTests()
        {
            Assertion(expected: 23, input: 10);
            Assertion(expected: 78, input: 20);
            Assertion(expected: 9168, input: 200);
            Assertion(expected: 0, input: 0);
        }

        [Test]
        public void NegativeTests()
        {
            Assertion(expected: 0, input: -10);
            Assertion(expected: 0, input: -20);
        }

        [Test]
        public void RandomTests()
        {
            Random rand = new Random();
            int input;
            int expected;

            int ReferenceSolution(int val)
            {
                var result = 0;
                for (int i = 1; i < val; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                        result += i;
                }
                return result;
            }

            for (int i = 0; i < 100; i++)
            {
                input = rand.Next(-2500, 20000);
                expected = ReferenceSolution(input);
                Assertion(expected, input);
            }
        }

        private static void Assertion(int expected, int input) =>
          ClassicAssert.AreEqual(
            expected,
            MultiplesOf3Or5.Solution(input),
            $"Value: {input}"
          );
    }
}