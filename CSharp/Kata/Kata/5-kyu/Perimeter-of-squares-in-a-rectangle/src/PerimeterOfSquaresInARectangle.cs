using System.Numerics;

namespace Kata._5kyu.Perimeter_Of_Squares_In_A_Rectangle.src
{
    public class PerimeterOfSquaresInARectangle
    {
        public static BigInteger Perimeter(BigInteger n) 
        {
            BigInteger curr = BigInteger.One;
            BigInteger sum = curr;
            BigInteger prev = BigInteger.Zero;
            BigInteger tmp;
            for (BigInteger i = BigInteger.One; i <= n; i++)
            {
                tmp = curr;
                curr = BigInteger.Add(curr, prev);
                prev = tmp;
                sum = BigInteger.Add(sum, curr);
            }
            return BigInteger.Multiply(sum, 4);
        }
    }
}