using System;
using System.Text;

namespace Kata._6_kyu.Give_me_a_Diamond.src;

public class Diamond
{
    public static string? Print(int n)
    {
        if (n <= 0 || n % 2 == 0)
            return null;

        var sb = new StringBuilder();
        var middle = n / 2;

        for (int i = 0; i < n; i++)
        {
            var spaces = Math.Abs(middle - i);
            sb.Append(new string(' ', spaces));
            sb.Append(new string('*', n - spaces * 2));
            sb.Append("\n");
        }
        return sb.ToString();
    }
}
