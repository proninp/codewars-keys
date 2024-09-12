using System;
using System.Globalization;

namespace Kata._8_kyu.Super_Duper_Easy.src
{
    public class SuperDuperEasy
    {
        public static string Problem(String a)
        {
            if (!double.TryParse(a, NumberFormatInfo.InvariantInfo, out var result))
                return "Error";
            return (result * 50 + 6).ToString();
        }
    }
}
