using System;
using System.Linq;

namespace Kata._6_kyu.Are_we_alternate.src;
public class AreWeAlternate
{
    public static bool IsAlt(string word)
    {
        char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
        for (int i = 1; i < word.Length; i++)
            if (!(vowels.Contains(word[i]) == vowels.Contains(word[i - 1])))
                return false;
        return true;
    }
}