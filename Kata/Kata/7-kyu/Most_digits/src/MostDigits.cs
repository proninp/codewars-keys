namespace Kata._7_kyu.Most_digits.src;

public class MostDigits
{
    public static int FindLongest(int[] number)
    {
        var max = FindDigitsCount(number[0]);
        var maxNumber = number[0];
        for(var i = 1; i < number.Length; i++)
        {
            var current = FindDigitsCount(number[i]);
            if (current > max)
            {
                max = current;
                maxNumber = number[i];
            }
        }
        return maxNumber;
    }
    private static int FindDigitsCount(int n)
    {
        var count = 0;
        var candidate = n < 0 ? (uint)(-(long)n) : (uint)n;
        while (candidate > 0)
        {
            candidate /= 10;
            count++;
        }
        return count;
    }
}