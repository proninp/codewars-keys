using System.Linq;

namespace Kata._7_kyu.Two_to_One.src;
public class TwoToOne
{
    public static string Longest(string s1, string s2)
    {
        return string.Concat(string.Concat(s1, s2).Distinct().OrderBy(c => c));
    }
}