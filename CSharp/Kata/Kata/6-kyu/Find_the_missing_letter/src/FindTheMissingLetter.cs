using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kata._6_kyu.Find_the_missing_letter.src
{
    public class FindTheMissingLetter
    {
        public static char FindMissingLetter(char[] array)
        {
            for (int i = 1; i < array.Length; i++)
                if (array[i - 1] + 1 != array[i])
                    return (char)(array[i - 1] + 1);
            return (char)(array[array.Length - 1] + 1);
        }
    }
}