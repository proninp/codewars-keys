namespace Kata._7_kyu.Is_this_a_triangle.src
{
    public class IsThisATriangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            return a != 0 && b != 0 && c != 0 && a + b > c && a + c > b && b + c > a;
        }
    }
}