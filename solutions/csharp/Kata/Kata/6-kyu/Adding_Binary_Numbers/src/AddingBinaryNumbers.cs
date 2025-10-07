using System;
using System.Collections.Generic;

namespace Kata._6_kyu.Adding_Binary_Numbers.src;
public class AddingBinaryNumbers
{
    public static string Add(string a, string b)
    {
        var remains = 0;
        var lenDiff = Math.Abs(a.Length - b.Length);
        if (lenDiff > 0)
        {
            var prefix = new string('0', lenDiff);
            if (a.Length > b.Length)
                b = prefix + b;
            else if (a.Length < b.Length)
                a = prefix + a;
        }
        var stack = new Stack<char>(Math.Max(a.Length, b.Length) + 1);
        for (var i = 0; i < a.Length; i++)
        {
            var index = a.Length - i - 1;
            var bit = a[index] - '0' + (b[index] - '0') + remains;
            remains = 0;
            if (bit > 1)
            {
                bit -= 2;
                remains++;
            }
            stack.Push((char)('0' + bit));
        }

        if (remains > 0)
            stack.Push((char)('0' + remains));
        
        while (stack.Count > 1 && stack.Peek() == '0')
            stack.Pop();
        
        return new string(string.Concat(stack));
    }
}
