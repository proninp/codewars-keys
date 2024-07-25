using System;
using System.Linq;

namespace Kata._7_kyu.Check_three_and_two.src
{
    public class CheckThreeAndTwoTask
    {
        public static bool CheckThreeAndTwo(string[] array)
        {
            var groups = array.GroupBy( c => c);
            return groups.Any(g => g.Count() == 3) && groups.Any(g => g.Count() == 2);
        }
    }
}