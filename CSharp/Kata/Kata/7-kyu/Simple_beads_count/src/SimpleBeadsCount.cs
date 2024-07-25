namespace Kata._7_kyu.Simple_beads_count.src
{
    public class SimpleBeadsCount
    {
        public static int CountRedBeads(int n)
        {
            return n < 2 ? 0 : (n - 1) * 2;
        }
    }
}