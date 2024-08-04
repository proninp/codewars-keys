using System.Linq;

namespace Kata._7_kyu.Find_the_Missing_Number.src
{
    public class FindTheMissingNumber
    {
        public static int MissingNo(int[] nums)
        {
            var n = 100;
            return n * (n + 1) / 2 - nums.Sum();
        }
    }
}