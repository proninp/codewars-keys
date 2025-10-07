using System.Numerics;

namespace Kata._7_kyu.By_3_or_not_by_3_That_is_the_question.src;
public class By3OrNotBy3ThatIsTheQuestion
{
    public static bool DivisibleByThree(string n) => BigInteger.Parse(n) % 3 == 0;
}