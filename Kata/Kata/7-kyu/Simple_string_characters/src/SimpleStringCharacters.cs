using System.Linq;

namespace Kata._7_kyu.Simple_string_characters.src;
public class SimpleStringCharacters
{
    public static int[] Solve(string s)
    {
        return new[]
        {
            s.Count(char.IsUpper),
            s.Count(char.IsLower),
            s.Count(char.IsDigit),
            s.Count(x => !char.IsLetterOrDigit(x))
        };
    }
}
