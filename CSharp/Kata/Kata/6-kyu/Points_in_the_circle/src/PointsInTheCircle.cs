using System;

namespace Kata._6_kyu.Points_in_the_circle.src
{
    public class PointsInTheCircle
    {
        public static int PointsNumber(int r)
        {
            var points = 0;
            for (int i = 0; i <= r; i++)
                points += (int)Math.Sqrt(r * r - i * i);
            return points * 4 + 1;
        }
    }
}