namespace Kata._6_kyu.What_century_is_it.src
{
    public class WhatCenturyIsIt
    {
        public static string WhatCentury(string year)
        {
            int century = (int.Parse(year) - 1) / 100 + 1;
            int remain = century % 10;
            return century +
                ((century > 10 && century < 14) || remain == 0 || remain > 3 ? "th" :
                remain == 1 ? "st" :
                remain == 2 ? "nd" :
                "rd");
        }
    }
}