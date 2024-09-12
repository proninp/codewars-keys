using System.Linq;
using System.Text;

namespace Kata._6_kyu.Ragbaby_cipher.src;
public class RagbabyCipher
{
    private static readonly string alphabet = "abcdefghijklmnopqrstuvwxyz";

    public static string Encode(string text, string key) => DoCipher(text, key, 1);

    public static string Decode(string text, string key) => DoCipher(text, key, -1);

    private static string DoCipher(string phrase, string key, int shiftSign)
    {
        var ka = key.Union(alphabet).Distinct().ToList();
        var newPhrase = new StringBuilder(phrase.Length);
        int shift = 0;
        foreach (var symbol in phrase)
        {
            if (!char.IsLetter(symbol))
            {
                newPhrase.Append(symbol);
                shift = 0;
                continue;
            }
            shift++;
            var kaIndex = ka.IndexOf(char.ToLower(symbol)) + (shift * shiftSign);
            if (kaIndex < 0) kaIndex = ka.Count + kaIndex;
            kaIndex %= ka.Count;
            var newChar = ka[kaIndex];
            if (char.IsUpper(symbol)) newChar = char.ToUpper(newChar);
            newPhrase.Append(newChar);
        }
        return newPhrase.ToString();
    }
}