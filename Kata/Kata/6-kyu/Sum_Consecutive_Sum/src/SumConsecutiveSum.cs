using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Kata._6_kyu.Sum_Consecutive_Sum.src;
public class SumConsecutiveSum
{
    public static int ConsecutiveSum(BigInteger[] arr)
    {
        Array.Sort(arr);
        var set = new HashSet<BigInteger>();
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] - 1 == arr[i - 1])
            {
                set.Add(arr[i - 1]);
                set.Add(arr[i]);
                int j = i + 1;
                while(j < arr.Length && arr[j] - 1 == arr[j - 1])
                    set.Add(arr[j++]);
                i = j;
            }
        }
        if (set.Count == 0) return 0;
        var sum = set.Aggregate(BigInteger.Add);
        return sum.ToString().Sum(d => d - '0');
    }
}
