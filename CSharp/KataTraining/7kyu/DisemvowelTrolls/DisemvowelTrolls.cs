using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7kyu.DisemvowelTrolls
{
    public class DisemvowelTrolls
    {
        private static List<char> _vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        public static string Disemvowel(string str) => string.Concat(str.Where(c => !_vowels.Contains(c)));
    }
}
