using System;
using System.Linq;

namespace _7kyu.Simple_Fun_176._Reverse_Letter
{
    public class ReverseLetterTask
    {
        public static string ReverseLetter(string str)
        {
           return new string(str.Reverse().Where(char.IsLetter).ToArray());
        }
    }
}
