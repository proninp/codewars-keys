using System;
using System.Linq;

namespace Kata._6_kyu.IP_Validation.src;
public class IPValidation
{
    public static bool IsValidIp(string ipAddres)
    {
        var oktets = ipAddres.Split('.', StringSplitOptions.RemoveEmptyEntries);
        if (oktets.Length != 4 )
            return false;
        if (oktets.Any(o => o.Length > 1 && o.StartsWith('0')))
            return false;
        return oktets.All(o =>
            int.TryParse(o.ToString(), out int n) && n >= 0 && n < 256 &&
            o.Equals(n.ToString()));
    }
}
