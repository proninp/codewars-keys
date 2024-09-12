using System.Linq;

namespace Kata._6_kyu.WeIrD_StRiNg_CaSe.src
{
    public class WeIrDStRiNgCaSe
    {
        public static string ToWeirdCase(string s)
        {
            return string.Join(' ', s.Split()
                .Select(s => string.Concat(s.Select((c, i) => i % 2 == 0 ? char.ToUpper(c) : char.ToLower(c)))));
        }
    }
}