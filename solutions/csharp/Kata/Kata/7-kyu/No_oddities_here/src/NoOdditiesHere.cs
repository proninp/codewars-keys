using System.Linq;

namespace Kata._7_kyu.No_oddities_here.src;
public class NoOdditiesHere
{
    public static int[] NoOdds(int[] values)
    {
        return values.Where(v => v % 2 == 0).ToArray();
    }
}
