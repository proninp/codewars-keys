using System.Linq;
using System.Numerics;

namespace Kata._6_kyu.Sum_Of_Groups.src;
public class SumOfGroups
{
    public static int SumOfDigitGroups(BigInteger[] numbers)
    {
        var groups = numbers.GroupBy(n => string.Concat(n.ToString().OrderBy(c => c)))
            .Where(g => g.Count() > 1)
            .Select(g => g.Min());
        return groups
           .DefaultIfEmpty(0)
           .Aggregate((sum, item) => sum + item)
           .ToString()
           .Sum(c => c - '0');
    }
}
