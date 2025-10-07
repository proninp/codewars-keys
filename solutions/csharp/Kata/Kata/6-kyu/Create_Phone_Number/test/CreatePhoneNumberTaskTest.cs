using System;
using System.Collections.Generic;
using Kata._6_kyu.Create_Phone_Number.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.Create_Phone_Number.test
{
    [TestFixture]
    public class CreatePhoneNumberTaskTest
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, ExpectedResult = "(123) 456-7890")]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, ExpectedResult = "(111) 111-1111")]
        public static string FixedTest(int[] numbers)
        {
            return CreatePhoneNumberTask.CreatePhoneNumber(numbers);
        }

        private static string Solution(int[] numbers)
        {
            string result = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0) result += "(";
                result += numbers[i];
                if (i == 2) result += ") ";
                if (i == 5) result += "-";
            }
            return result;
        }

        [Test]
        public static void RandomTest([Random(0, 9, 50)] int num)
        {
            List<int> list = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 10; i++) list.Add(r.Next(10));
            int[] numbers = list.ToArray();
            ClassicAssert.AreEqual(Solution(numbers), CreatePhoneNumberTask.CreatePhoneNumber(numbers));
        }
    }
}