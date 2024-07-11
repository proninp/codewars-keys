namespace _6kyu.Multiples_of_3_or_5
{
    public class MultiplesOf3Or5
    {
        public static int Solution(int value)
        {
            int sum = 0;
            for (int i = 3; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }
            return sum;
        }
    }
}
