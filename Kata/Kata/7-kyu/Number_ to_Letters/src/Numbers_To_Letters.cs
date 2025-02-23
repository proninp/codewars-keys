using System.Linq;

namespace Kata._7_kyu.Number__to_Letters.src;
public class Numbers_To_Letters
{
    public static string Switcher(string[] x) =>
        string.Concat(x.Select(n => "zyxwvutsrqponmlkjihgfedcba!? "[int.Parse(n) - 1]));
}
