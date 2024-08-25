using System.Linq;

namespace Kata._7_kyu.Descending_Order.src;
public class DescendingOrderTask
{
    public static int DescendingOrder(int num)
    {
        return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
    }
}