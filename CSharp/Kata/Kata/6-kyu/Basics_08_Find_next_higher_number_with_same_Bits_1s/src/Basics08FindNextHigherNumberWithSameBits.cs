using System;

namespace Kata._6_kyu.Basics_08_Find_next_higher_number_with_same_Bits_1s.src
{
    public class Basics08FindNextHigherNumberWithSameBits
    {
        public static int NextHigher(int value)
        {
            var binaryArray = string.Concat("0", Convert.ToString(value, 2)).ToCharArray();
            for(int i = binaryArray.Length - 1; i > 0; i--) 
                if (binaryArray[i - 1] == '0' && binaryArray[i] == '1')
                {
                    (binaryArray[i - 1], binaryArray[i]) = ('1', '0');
                    Array.Sort(binaryArray, i, binaryArray.Length - i);
                    return Convert.ToInt32(string.Concat(binaryArray), 2);
                }
            return -1;
        }
    }
}