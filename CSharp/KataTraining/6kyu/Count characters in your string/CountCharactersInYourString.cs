using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6kyu.Count_characters_in_your_string
{
    public class CountCharactersInYourString
    {
        public static Dictionary<char, int> Count(string str) =>
            str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
    }
}
