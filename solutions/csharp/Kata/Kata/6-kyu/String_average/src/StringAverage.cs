using System.Collections.Generic;
using System.Linq;

namespace Kata._6_kyu.String_average.src
{
    public class StringAverage
    {
        public static string AverageString(string str)
        {
            var map = new Dictionary<string, int> {
                {"zero" , 0},
                {"one" , 1},
                {"two" , 2},
                {"three" , 3},
                {"four" , 4},
                {"five" , 5},
                {"six" , 6},
                {"seven" , 7},
                {"eight" , 8},
                {"nine" , 9}
            };

            var sum = 0;
            var elements = str.Split(" ");
            foreach (var s in elements)
            {
                if (!map.ContainsKey(s))
                    return "n/a";
                sum += map[s];
            }
            int seek = sum / elements.Length;
            return map.ContainsValue(seek) ? map.First(x => x.Value == seek).Key : "n/a";
        }
    }
}