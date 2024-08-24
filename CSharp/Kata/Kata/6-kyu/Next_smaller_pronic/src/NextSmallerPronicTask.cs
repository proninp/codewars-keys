using System;

namespace Kata._6_kyu.Next_smaller_pronic.src;
public class NextSmallerPronicTask
{
    public static ulong NextSmallerPronic(ulong x)
    {
        ulong n = (ulong)Math.Sqrt(x);
        if (n * n + n >= x)
            n -= 1;
        return n * n + n;
    }
}