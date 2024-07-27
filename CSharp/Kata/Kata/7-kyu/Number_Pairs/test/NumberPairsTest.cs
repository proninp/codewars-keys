using System;
using System.Collections.Generic;
using System.Linq;
using Kata._7_kyu.Number_Pairs.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.Number_Pairs.test
{
    [TestFixture]
    public class NumberPairsTest
    {
        [TestCase]
        //Fixed values
        public void getLargerNumber()
        {
            int[] arr1 = [13, 64, 15, 17, 88];
            int[] arr2 = [23, 14, 53, 17, 80];
            ClassicAssert.AreEqual(NumberPairs.GetLargerNumbers(arr1, arr2), new int[] { 23, 64, 53, 17, 88 });
        }

        [Test]
        //Generate 5 random values for each array
        public void getLarger()
        {
            int[] arr = generateRandomArray(0, 99);
            int[] arr2 = generateRandomArray(0, 99);

            Console.WriteLine();
            Console.WriteLine("Generated Array 1");
            foreach (int i in arr)
                Console.Write(i + " ");

            Console.WriteLine();
            Console.WriteLine("Generated Array 2");
            foreach (int j in arr2)
                Console.Write(j + " ");

            ClassicAssert.AreEqual(NumberPairs.GetLargerNumbers(arr, arr2), myLargerNumbers(arr, arr2));
        }

        [Test]
        //Generate 100 Testcases, using NUnit Random to generate values
        //Array size varies randomly from 1 to 10
        public static void RandomTest([Random(1, 10, 100)] int x)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                list1.Add(r.Next(100));
                list2.Add(r.Next(100));
            }

            Console.WriteLine();
            Console.WriteLine("Generated Array 1");
            foreach (int i in list1)
                Console.Write(i + " ");

            Console.WriteLine();
            Console.WriteLine("Generated Array 2");
            foreach (int j in list2)
                Console.Write(j + " ");

            ClassicAssert.AreEqual(Solution(list1.ToArray(), list2.ToArray()), NumberPairs.GetLargerNumbers(list1.ToArray(), list2.ToArray()));
        }

        private static int[] Solution(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Math.Max(a[i], b[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Compared Array of Large Numbers");
            foreach (int i in a)
                Console.Write(i + " ");

            return a;
        }



        public static int[] generateRandomArray(int min, int max)
        {
            Random randNum = new Random();

            int[] myArr = Enumerable
                .Repeat(0, 5)
               .Select(i => randNum.Next(min, max))
               .ToArray();
            return myArr;
        }

        public int[] myLargerNumbers(int[] a, int[] b)
        {
            List<int> largerList = new List<int>();
            var largerElements = a.Zip(b, (first, second) => first > second ? first : second);
            foreach (var item in largerElements)
            { largerList.Add(item); }

            Console.WriteLine();
            Console.WriteLine("Compared Array of Large Numbers");
            foreach (int i in largerList)
                Console.Write(i + " ");

            return largerList.ToArray();
        }
    }
}