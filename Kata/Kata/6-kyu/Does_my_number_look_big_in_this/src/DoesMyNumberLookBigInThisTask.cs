using System;
using System.Linq;

namespace Kata._6_kyu.Does_my_number_look_big_in_this.src;
public class DoesMyNumberLookBigInThisTask
{
    public static bool Narcissistic(int value)
    {
        var str = value.ToString();
        return str.Sum(c => Math.Pow(Convert.ToInt16(c.ToString()), str.Length)) == value;
    }
}
