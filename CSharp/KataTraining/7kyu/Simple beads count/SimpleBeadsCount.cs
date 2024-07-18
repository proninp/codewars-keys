namespace _7kyu.Simple_beads_count
{
    public class SimpleBeadsCount
    {
        public static int CountRedBeads(int n)
        {
            return n < 2 ? 0 : (n - 1) * 2;
        }
    }
}
