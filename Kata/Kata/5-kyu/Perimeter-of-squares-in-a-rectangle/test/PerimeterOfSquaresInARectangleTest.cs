using System;
using System.Numerics;
using Kata._5kyu.Perimeter_Of_Squares_In_A_Rectangle.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._5_kyu.Perimeter_of_squares_in_a_rectangle.test
{
    //PerimeterOfSquaresInARectangleTest
    [TestFixture]
    public class PerimeterOfSquaresInARectangleTest
    {

        [Test]
        public void Test1()
        {
            ClassicAssert.AreEqual(new BigInteger(80), PerimeterOfSquaresInARectangle.Perimeter(new BigInteger(5)));
        }
        [Test]
        public void Test2()
        {
            ClassicAssert.AreEqual(new BigInteger(216), PerimeterOfSquaresInARectangle.Perimeter(new BigInteger(7)));
        }
        [Test]
        public void Test3()
        {
            ClassicAssert.AreEqual(new BigInteger(14098308), PerimeterOfSquaresInARectangle.Perimeter(new BigInteger(30)));
        }
        [Test]
        public void Test4()
        {
            BigInteger bigInt = 0;
            bigInt = BigInteger.Parse("6002082144827584333104");
            ClassicAssert.AreEqual(bigInt, PerimeterOfSquaresInARectangle.Perimeter(new BigInteger(100)));
        }
        [Test]
        public void Test5()
        {
            BigInteger bigInt = 0;
            bigInt = BigInteger.Parse("2362425027542282167538999091770205712168371625660854753765546783141099308400948230006358531927265833165504");
            ClassicAssert.AreEqual(bigInt, PerimeterOfSquaresInARectangle.Perimeter(new BigInteger(500)));
        }

        //---------------------------------------
        public static BigInteger Solution130412(BigInteger n)
        {
            BigInteger res = new BigInteger(1);
            BigInteger tmp = new BigInteger(1);
            BigInteger prev = new BigInteger(1);
            BigInteger next = new BigInteger(1);
            BigInteger four = new BigInteger(4);
            for (BigInteger i = new BigInteger(1); i <= n; i++)
            {
                res = BigInteger.Add(res, next);
                tmp = next;
                next = BigInteger.Add(next, prev);
                prev = tmp;
            }
            return BigInteger.Multiply(res, four);
        }
        
        [Test]
        public static void Test6()
        {
            Console.WriteLine("\n Random Tests ****************");
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                int n = rnd.Next(100, 50000);
                Console.WriteLine("Number : " + n);
                ClassicAssert.AreEqual(Solution130412(n), PerimeterOfSquaresInARectangle.Perimeter(new BigInteger(n)));
            }
        }
    }
}