using System.Linq;

namespace Kata._7_kyu.Return_the_Missing_Element.src
{
    public class ReturnTheMissingElement
    {
        public static int GetMissingElement(int[] superImportantArray) =>
            Enumerable.Range(0, 10).Sum() - superImportantArray.Sum();
        
    }
}