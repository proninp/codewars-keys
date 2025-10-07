using System.Linq;

namespace Kata._7_kyu.Highest_and_Lowest.src
{
    public class HighestAndLowest
    {
        public static string HighAndLow(string numbers)
        {
            var list = numbers.Split(' ').Select(int.Parse);
            return $"{list.Max()} {list.Min()}";
        }
    }
}