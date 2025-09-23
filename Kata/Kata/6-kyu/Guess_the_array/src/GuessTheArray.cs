using System;

namespace Kata._6_kyu.Guess_the_array.src;

public class GuessTheArray
{
    public static int[] Guess(Func<int, int, int> f, int i)
    {
        var result = new int[i];
        var fs = f(0, 1);
        var st = f(1, 2);
        var ft = f(0, 2);
        
        result[1] = (fs + st - ft) / 2;
        result[0] = fs - result[1];
        result[2] = st - result[1];

        for (var j = 3; j < i; j++)
        {
            result[j] = f(j, j - 1) - result[j - 1];
        }
        return result;
    }
}