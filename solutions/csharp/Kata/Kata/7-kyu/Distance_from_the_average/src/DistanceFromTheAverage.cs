using System;
using System.Linq;

namespace Kata._7_kyu.Distance_from_the_average.src
{
    public class DistanceFromTheAverage
    {
        public static double[] DistancesFromAverage(int[] input)
        {
            var avg = input.Average();
            return input.Select(x => Math.Round(avg - x, 1)).ToArray();
        }
    }
}