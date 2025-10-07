namespace Kata._6_kyu.Sum_of_Digits_Digital_Root.src;
public class SumOfDigitsDigitalRoot
{
    public static int DigitalRoot(long n)
    {
        long sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum < 10 ? (int)sum : DigitalRoot(sum);
    }
}
