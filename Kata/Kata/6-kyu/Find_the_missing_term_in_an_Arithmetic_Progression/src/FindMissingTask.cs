using System.Collections.Generic;
using System.Linq;

namespace Kata._6_kyu.Find_the_missing_term_in_an_Arithmetic_Progression.src
{
    public class FindMissingTask
    {
        public static int FindMissing(List<int> list) =>
            (int)((list.Count + 1) / 2.0 * (list.First() + list.Last()) - list.Sum(x => (long)x));
        
        public static int FindMissing2(List<int> list)
        {
            var l = list[1] - list[0];
            var r = list[^1] - list[^2];
            if (l == r)
            {
                for (int i = 1; i < list.Count - 1; i++)
                {
                    if (list[i + 1] - list[i] != l)
                    {
                        return list[i] + l;  
                    }
                }
            }
            return r > l ? list[^1] - l : list[0] + r;
        }
    }
}