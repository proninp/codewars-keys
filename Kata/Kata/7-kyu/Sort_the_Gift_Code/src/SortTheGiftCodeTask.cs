using System.Linq;

namespace Kata._7_kyu.Sort_the_Gift_Code.src
{
    public class SortTheGiftCodeTask
    {
        public static string SortGiftCode(string code)
        {
            return string.Concat(code.OrderBy(c => c));
        }
    }
}
