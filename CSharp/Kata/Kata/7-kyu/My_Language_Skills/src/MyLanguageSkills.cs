using System.Collections.Generic;
using System.Linq;

namespace Kata._7_kyu.My_Language_Skills.src
{
    public class MyLanguageSkills
    {
        public static IEnumerable<string> MyLanguages(Dictionary<string, int> results) =>
             results.Where(x => x.Value >= 60).OrderByDescending(x => x.Value).Select(x => x.Key);
    }
}