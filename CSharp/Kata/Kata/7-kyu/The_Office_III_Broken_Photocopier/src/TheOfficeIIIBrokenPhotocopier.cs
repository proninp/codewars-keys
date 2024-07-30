using System.Linq;

namespace Kata._7_kyu.The_Office_III_Broken_Photocopier.src
{
    public class TheOfficeIIIBrokenPhotocopier
    {
        public static string Broken(string x)
        {
            return string.Join("", x.Select(x => x == '0' ? '1' : '0'));
        }
    }
}