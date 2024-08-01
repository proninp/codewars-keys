using System.Collections.Generic;
using System.Linq;

namespace Kata._6_kyu.Find_the_missing_term_in_an_Arithmetic_Progression.src
{
    public class FindMissingTask
    {
        public static int FindMissing(List<int> list) =>
            (int)((list.Count + 1) / 2.0 * (list.First() + list.Last()) - list.Sum(x => (long)x));
        
    }
}