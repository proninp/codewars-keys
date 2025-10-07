using System;

namespace Kata._6_kyu.Pentabonacci.src;

public sealed class Pentanacci
{
    public static long CountOddPentaFib(long n)
    {
        const int period = 6;
        if (n <= period) return Math.Min(1, n);

        var periods = n / period;
        var remains = n % period;
        var odds = (periods << 1) + Math.Min(2, remains);
        return odds - 1;
    }
}