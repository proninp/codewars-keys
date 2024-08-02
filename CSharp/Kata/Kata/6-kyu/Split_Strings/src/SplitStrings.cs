using System.Linq;

namespace Kata._6_kyu.Split_Strings.src
{
    public class SplitStrings
    {
        public static string[] Solution(string str)
        {
            if (str.Length % 2 != 0) str += "_";
            return Enumerable.Range(0, str.Length / 2).Select(x => str.Substring(x * 2, 2)).ToArray();
        }
    }
}