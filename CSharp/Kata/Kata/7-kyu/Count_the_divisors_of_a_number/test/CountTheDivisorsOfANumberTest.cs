using Kata._7_kyu.Count_the_divisors_of_a_number.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Linq;

namespace Kata._7_kyu.Count_the_divisors_of_a_number.test
{
    [TestFixture]
    public class CountTheDivisorsOfANumberTest
    {
        private static Random rnd = new Random();

        private static int Solution(int n)
        {
            int count = 0;
            double sqrt = Math.Sqrt(n);
            for (int i = 1; i <= sqrt; ++i)
            {
                if (n % i == 0) count += 2;
                if (i == sqrt) --count;
            }
            return count;
        }

        [Test]
        public void SampleTest()
        {
            Action[] tests = new Action[]
            {
                () => ClassicAssert.AreEqual(1, CountTheDivisorsOfANumber.Divisors(1)),
                () => ClassicAssert.AreEqual(4, CountTheDivisorsOfANumber.Divisors(10)),
                () => ClassicAssert.AreEqual(2, CountTheDivisorsOfANumber.Divisors(11)),
                () => ClassicAssert.AreEqual(8, CountTheDivisorsOfANumber.Divisors(54)),
                () => ClassicAssert.AreEqual(3, CountTheDivisorsOfANumber.Divisors(25)),
            };
            tests.OrderBy(x => rnd.Next()).ToList().ForEach(a => a.Invoke());
        }

        [Test]
        public void RandomTest()
        {
            for (int i = 0; i < 100; ++i)
            {
                int test = rnd.Next(0, 500000);
                int expected = Solution(test);
                int actual = CountTheDivisorsOfANumber.Divisors(test);
                Console.WriteLine("Testing:  {0}\nExpected: {1}\nActual:   {2}\n", test, expected, actual);
                ClassicAssert.AreEqual(expected, actual);
            }
        }
    }
}
