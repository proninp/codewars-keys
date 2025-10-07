using System.Collections.Generic;

namespace Kata._6_kyu.Find_the_unique_number.src
{
    public class FindTheUniqueNumber
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            var e = numbers.GetEnumerator();
            e.MoveNext();
            var f = e.Current;
            e.MoveNext();
            var s = e.Current;
            while (e.MoveNext())
                if (e.Current != f || e.Current != s)
                    return f ^ s ^ e.Current;
            return e.Current;
        }
    }
}