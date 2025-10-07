using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata._6_kyu.Count_characters_in_your_string.src
{
    public class CountCharactersInYourString
    {
        public static Dictionary<char, int> Count(string str) =>
            str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
    }
}