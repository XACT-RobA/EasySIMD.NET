using System;
using System.Numerics;

namespace EasySIMD.NET
{
    public static class BasicMathsExtensions
    {
        public static float[] Add(this float[] left, float[] right)
        {
            return left.Map(right, (vleft, vright) => vleft + vright, (sleft, sright) => sleft + sright);
        }
    }
}