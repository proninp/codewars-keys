using System;

namespace Kata._6_kyu.Playing_with_passphrases.src;

public class PlayingWithPassphrases
{
    public static string PlayPass(string s, int n)
    {
        var charArr = new char[s.Length];
        for (var i = 0; i < s.Length; i++)
        {
            char newChar;
            if (char.IsDigit(s[i]))
            {
                newChar = (char)(105 - s[i]);
            }
            else if (char.IsLetter(s[i]))
            {
                newChar = (char)((char.ToLower(s[i]) - 'a' + n) % 26 + 'a');
                newChar = i % 2 == 0 ? char.ToUpper(newChar) : newChar;
            }
            else
            {
                newChar = s[i];
            }
            charArr[s.Length - i - 1] = newChar;
        }
        return new string(charArr);
    }
}