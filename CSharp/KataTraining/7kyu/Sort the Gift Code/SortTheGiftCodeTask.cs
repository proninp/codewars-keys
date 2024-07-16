using System.Linq;

namespace _7kyu.Sort_the_Gift_Code
{
    public class SortTheGiftCodeTask
    {
        public static string SortGiftCode(string code)
        {
            return string.Concat(code.OrderBy(c => c));
        }
    }
}
