using System;

namespace Kata._5_kyu.RGB_To_Hex_Conversion
{
    public class RGBToHexConversion
    {
        public static string Rgb(int r, int g, int b)
        {
            return string.Format("{0}{1}{2}",
                ToHexColor(r),
                ToHexColor(g),
                ToHexColor(b));
        }
        private static string ToHexColor(int x) =>
            Math.Max(Math.Min(x, 255), 0).ToString("X2");
    }
}
