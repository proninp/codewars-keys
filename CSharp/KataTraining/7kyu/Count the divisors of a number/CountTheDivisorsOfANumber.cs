using System;

namespace _7kyu.Count_the_divisors_of_a_number
{
    public class CountTheDivisorsOfANumber
    {
        public static int Divisors(int n)
        {
            int divisorsCount = 1;
            if (n == 1)
                return divisorsCount;
            divisorsCount++; // 1 and n

            for (int i = 2; i <= n/2; i++) // no number can have a factor larger than a half of itself
                if (n % i == 0)
                    divisorsCount++;

            return divisorsCount;
        }
    }
}
