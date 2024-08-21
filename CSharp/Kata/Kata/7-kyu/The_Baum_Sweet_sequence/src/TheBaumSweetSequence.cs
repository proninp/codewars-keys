using System;
using System.Collections.Generic;

namespace Kata._7_kyu.The_Baum_Sweet_sequence.src
{
    public class TheBaumSweetSequence
    {
        public static IEnumerable<int> BaumSweet()
        {
            yield return 1;
            int n = 1;
            while (n < 1_000_001)
            {
                var b = Convert.ToString(n++, 2).ToCharArray();
                int baum = 1;
                for(int i = 0; i < b.Length; i++)
                {
                    if (b[i] == '1') continue;
                    int cnt = 1;
                    int j = i + 1;
                    for( ; j < b.Length; j++)
                    {
                        if (b[j] == '1') break;
                        cnt++;
                    }
                    i = j;
                    if (cnt % 2 == 1)
                    {
                        baum = 0;
                        i = b.Length;
                    }
                }
                yield return baum;
            }
        }
    }
}