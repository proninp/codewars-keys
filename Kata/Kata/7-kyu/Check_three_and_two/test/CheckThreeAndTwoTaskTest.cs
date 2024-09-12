using Kata._7_kyu.Check_three_and_two.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;

namespace Kata._7_kyu.Check_three_and_two.test
{
    [TestFixture]
    public class CheckThreeAndTwoTaskTest
    {
        public static bool CheckThreeAndTwoTest(string[] array)
        {
            Dictionary<string, int> letters = new Dictionary<string, int>();
            foreach (string s in array)
            {
                if (letters.ContainsKey(s))
                    letters[s]++;
                else
                    letters.Add(s, 1);
            }

            if (letters.Count == 2)
            {
                bool hasTwo = false;
                bool hasThree = false;
                foreach (var item in letters)
                {
                    if (item.Value == 2) hasTwo = true;
                    if (item.Value == 3) hasThree = true;
                }
                return hasTwo && hasThree;
            }

            return false;
        }

        [Test]
        public void BasicTests()
        {
            RunTest(true, ["a", "a", "a", "b", "b"]);
            RunTest(false, ["a", "c", "a", "c", "b"]);
            RunTest(false, ["a", "a", "a", "a", "a"]);
        }

        [Test]
        public void RandomTests()
        {
            string[] deck = ["a", "b", "c"];
            const int arraySize = 5;
            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                string[] array = new string[arraySize];
                for (int j = 0; j < arraySize; j++)
                {
                    array[j] = deck[rand.Next(0, deck.Length)];
                }

                RunTest(CheckThreeAndTwoTest(array), array);
            }
        }

        private void RunTest(bool expected, string[] array)
        {
            Console.WriteLine(string.Join(", ", array) + ": expect " + expected.ToString());
            ClassicAssert.AreEqual(expected, CheckThreeAndTwoTask.CheckThreeAndTwo(array));
        }
    }
}
