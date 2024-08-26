using System.Linq;

namespace Kata._6_kyu.Your_order_please.src;
public class YourOrderPlease
{
    public static string Order(string words)
    {
        return string.IsNullOrEmpty(words) ?
            words :
            string.Join(" ", words.Split().OrderBy(w => w.ToList().Find(c => char.IsDigit(c))));
    }
}