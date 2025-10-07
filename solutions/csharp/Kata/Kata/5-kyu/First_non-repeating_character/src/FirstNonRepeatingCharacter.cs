using System;
using System.Linq;

namespace Kata._5_kyu.First_non_repeating_character.src
{
    public class FirstNonRepeatingCharacter
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            return s.GroupBy(char.ToLower)
                    .Where(gr => gr.Count() == 1)
                    .Select(gr => gr.First().ToString())
                    .DefaultIfEmpty("")
                    .First();
        }
    }
}