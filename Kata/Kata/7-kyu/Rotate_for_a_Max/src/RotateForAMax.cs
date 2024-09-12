namespace Kata._7_kyu.Rotate_for_a_Max.src
{
    public class RotateForAMax
    {
        public static long MaxRot(long n)
        {
            long max = n;
            string str = n.ToString();
            for (int i = 0; i < str.Length - 1; i++)
            {
                str = str.Substring(0, i) + str.Substring(i + 1) + str.Substring(i, 1);
                n = long.Parse(str);
                if (n > max) max = n;
            }
            return max;
        }
    }
}