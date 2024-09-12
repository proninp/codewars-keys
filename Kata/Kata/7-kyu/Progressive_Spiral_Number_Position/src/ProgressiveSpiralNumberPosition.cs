using System;

namespace Kata._7_kyu.Progressive_Spiral_Number_Position.src;
public class ProgressiveSpiralNumberPosition
{
    public static long Layers(long n) =>
        (long)Math.Ceiling((Math.Sqrt(n) + 1) / 2);
}
