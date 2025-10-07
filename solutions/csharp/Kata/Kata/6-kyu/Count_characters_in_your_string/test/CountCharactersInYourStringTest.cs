using System;
using System.Collections.Generic;
using System.Text;
using Kata._6_kyu.Count_characters_in_your_string.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.Count_characters_in_your_string.test
{
    [TestFixture]
    public class CountCharactersInYourStringTest
    {
        private static void Tester(Dictionary<char, int> expected, Dictionary<char, int> submitted, string input)
        {
            foreach (KeyValuePair<char, int> entry in expected)
            {
                char key = entry.Key;
                if (submitted.ContainsKey(key))
                {
                    int val = entry.Value;
                    int num = submitted[key];
                    if (num != val)
                        ClassicAssert.AreEqual(val, num, $"For input string: \"{input}\"\n \n< Incorrect Value for Key '{key}' >");
                }
                else
                    ClassicAssert.AreEqual(true, false,
                        $"For input string: \"{input}\"\n \n< The submitted Dictionary should contain an entry for key '{entry.Key}' >");
            }
            foreach (KeyValuePair<char, int> entry in submitted)
            {
                if (expected.ContainsKey(entry.Key) == false)
                {
                    ClassicAssert.AreEqual(false, true,
                        $"For input string: \"{input}\"\n \n< The submitted Dictionary should NOT contain an entry for key '{entry.Key}' >");
                }
            }
            ClassicAssert.AreEqual(true, true);
        }
        [Test]
        public static void FixedTest()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            string s = "";
            Tester(d, CountCharactersInYourString.Count(s), s);
        }
        [Test]
        public static void FixedTestA()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 1);
            string s = "a";
            Tester(d, CountCharactersInYourString.Count(s), s);
        }
        [Test]
        public static void FixedTestAaa()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 3);
            string s = "aaa";
            Tester(d, CountCharactersInYourString.Count(s), s);
        }
        [Test]
        public static void FixedTestAba()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 2);
            d.Add('b', 1);
            string s = "aba";
            Tester(d, CountCharactersInYourString.Count(s), s);
        }
        [Test]
        public static void FixedTestAbab()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 2);
            d.Add('b', 2);
            string s = "abab";
            Tester(d, CountCharactersInYourString.Count(s), s);
        }
        private static Dictionary<char, int> Solution(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (dict.ContainsKey(c))
                    dict[c] = dict[c] + 1;
                else
                    dict.Add(c, 1);
            }
            return dict;
        }
        private static string GetRandomString(int length)
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            StringBuilder sb = new StringBuilder();
            Random r = new Random();
            for (int i = 0; i < length; i++)
                sb.Append(alpha[r.Next(26)]);
            return sb.ToString();
        }
        [Test]
        public static void RandomTest([Random(5, 100, 100)] int length)
        {
            string s = GetRandomString(length);
            Tester(Solution(s), CountCharactersInYourString.Count(s), s);
        }
    }
}