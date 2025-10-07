using System.Linq;

namespace Kata._6_kyu.Break_camelCase.src
{
    public class BreakCamelCaseTask
    {
        public static string BreakCamelCase(string str) =>
            string.Concat(str.Select(c => char.IsUpper(c) ? " " + c : c.ToString()));
    }
}