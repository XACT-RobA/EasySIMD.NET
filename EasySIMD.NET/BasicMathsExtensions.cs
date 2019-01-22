using System;
using System.Numerics;

namespace EasySIMD.NET
{
    public static class BasicMathsExtensions
    {
        public static float[] Add(this float[] left, float[] right)
            => left.Map(right, VectorOperators.Add, ScalarOperators.Add);
        public static double[] Add(this double[] left, double[] right)
            => left.Map(right, VectorOperators.Add, ScalarOperators.Add);
        

        public static float[] Subtract(this float[] left, float[] right)
            => left.Map(right, VectorOperators.Subtract, ScalarOperators.Subtract);

        public static float[] Multiply(this float[] left, float[] right)
            => left.Map(right, VectorOperators.Multiply, ScalarOperators.Multiply);

        public static float[] Divide(this float[] left, float[] right)
            => left.Map(right, VectorOperators.Divide, ScalarOperators.Divide);
    }
}