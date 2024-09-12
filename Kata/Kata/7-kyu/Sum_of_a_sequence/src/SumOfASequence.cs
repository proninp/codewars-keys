namespace Kata._7_kyu.Sum_of_a_sequence.src
{
    public class SumOfASequence
    {
        public static int SequenceSum(int start, int end, int step)
        {
            int sum = 0;
            for (int i = start; i <= end; i += step)
                sum += i;
            return sum;
        }
    }
}