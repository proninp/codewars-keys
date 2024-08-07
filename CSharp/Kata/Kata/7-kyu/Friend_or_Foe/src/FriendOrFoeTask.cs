using System.Collections.Generic;
using System.Linq;

namespace Kata._7_kyu.Friend_or_Foe.src
{
    public class FriendOrFoeTask
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(s => s.Length == 4);
        }
    }
}