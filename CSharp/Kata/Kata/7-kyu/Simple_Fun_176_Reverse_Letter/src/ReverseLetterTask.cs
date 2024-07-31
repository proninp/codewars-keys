using System;
using System.Linq;

namespace Kata._7_kyu.Simple_Fun_176._Reverse_Letter.src
{
    public class ReverseLetterTask
    {
        public string ReverseLetter(string str)
        {
           return new string(str.Reverse().Where(char.IsLetter).ToArray());
        }
    }
}
