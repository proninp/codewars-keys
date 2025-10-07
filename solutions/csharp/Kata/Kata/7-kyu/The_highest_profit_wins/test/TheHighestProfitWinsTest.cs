using System;
using System.Linq;
using Kata._7_kyu.The_highest_profit_wins.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.The_highest_profit_wins.test
{
    [TestFixture]
    public class TheHighestProfitWinsTest
    {
        [Test]
        public static void BasicTest()
        {
            ClassicAssert.AreEqual(new int[] { -1, 20 }, TheHighestProfitWins.MinMax([1, 2, 5, -1, 12, 20]));
            ClassicAssert.AreEqual(new int[] { 1, 5 }, TheHighestProfitWins.MinMax([1, 2, 3, 4, 5]));
            ClassicAssert.AreEqual(new int[] { -3, 5 }, TheHighestProfitWins.MinMax([1, 2, -3, 4, 5]));
            ClassicAssert.AreEqual(new int[] { -5, 9 }, TheHighestProfitWins.MinMax([1, 9, 3, 4, -5]));
            ClassicAssert.AreEqual(new int[] { -214, 542 }, TheHighestProfitWins.MinMax([4, 5, 29, 54, 4, 0, -214, 542, -64, 1, -3, 6, -6]));
            ClassicAssert.AreEqual(new int[] { 4, 4 }, TheHighestProfitWins.MinMax([4]));
        }

        [Test]
        public static void RandomTestArrayOneElement()
        {
            Random random = new Random();
            int rn = random.Next(1, 500);
            for (int i = 0; i < 10; i++)
            {
                ClassicAssert.AreEqual(new int[] { rn, rn }, TheHighestProfitWins.MinMax([rn]));
            }
        }

        //-----------------------
        private static int[] Comb(int k)
        {
            Random random = new Random();
            int[] res = new int[k];
            for (int i = 0; i < k; i++)
            {
                int x = random.Next(1, 10000);
                int y = random.Next(17, 29);
                int sgn = random.Next(0, 10);
                if (sgn == 0)
                    x = -x;
                res[i] = x * y;
            }
            return res;
        }
        private static int[] MinMaxSol(int[] lst) => [lst.Min(), lst.Max()];

        //-----------------------

        [Test]
        public static void RandomTestBiggerArrays()
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int[] lst = Comb(random.Next(10, 50));
                ClassicAssert.AreEqual(MinMaxSol(lst), TheHighestProfitWins.MinMax(lst));
            }
        }
    }
}