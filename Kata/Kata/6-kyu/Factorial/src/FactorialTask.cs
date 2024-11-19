using System;

namespace Kata._6_kyu.Factorial.src
{
    public class FactorialTask
    {
        public static int Factorial(int n)
        {
            if (n is < 0 or > 12)
                throw new ArgumentOutOfRangeException();
            var result = 1;
            for (var i = 2; i <= n; i++)
                result *= i;
            return result;
        }
    }
}
