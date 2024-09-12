using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Kata._6_kyu.Sum_Of_Groups.src;
public class SumOfGroups
{
    public static int SumOfDigitGroups(BigInteger[] numbers)
    {
        var map = new Dictionary<string, List<BigInteger>>();

        foreach (var number in numbers)
        {
            var key = string.Concat(number.ToString().OrderByDescending(c => c));
            if (!map.ContainsKey(key))
                map.Add(key, new List<BigInteger>());
            map[key].Add(number);
        }

        var groups = map.Select(kvp => kvp.Value).Where(gr => gr.Distinct().Count() > 1);
        return groups
            .Select(e => e.Min())
            .DefaultIfEmpty(0)
            .Aggregate((sum, item) => sum + item)
            .ToString()
            .Sum(c => c - '0');
    }
}
