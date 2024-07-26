using System.Collections.Generic;

namespace Kata._6_kyu.The_PaperFold_sequence.src
{
    public class ThePaperFoldSequence
    {
        public static IEnumerable<int> PaperFold()
        {
            int i = 0;
            while (i < 1_000_001) 
                yield return ((++i) & (i & -i) << 1) == 0 ? 1 : 0;
        }
    }
}
