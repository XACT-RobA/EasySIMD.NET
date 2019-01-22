using System;
using System.Numerics;

namespace EasySIMD.NET
{
    public static class BasicMathsExtensions
    {
        // Add
        public static float[] Add(this float[] left, float[] right)
            => left.Map(right, VectorOperators.Add, ScalarOperators.Add);
        public static double[] Add(this double[] left, double[] right)
            => left.Map(right, VectorOperators.Add, ScalarOperators.Add);
        
        // Subtract
        public static float[] Subtract(this float[] left, float[] right)
            => left.Map(right, VectorOperators.Subtract, ScalarOperators.Subtract);
        public static double[] Subtract(this double[] left, double[] right)
            => left.Map(right, VectorOperators.Subtract, ScalarOperators.Subtract);

        // Multiply
        public static float[] Multiply(this float[] left, float[] right)
            => left.Map(right, VectorOperators.Multiply, ScalarOperators.Multiply);
        public static double[] Multiply(this double[] left, double[] right)
            => left.Map(right, VectorOperators.Multiply, ScalarOperators.Multiply);

        // Divide
        public static float[] Divide(this float[] left, float[] right)
            => left.Map(right, VectorOperators.Divide, ScalarOperators.Divide);
        public static double[] Divide(this double[] left, double[] right)
            => left.Map(right, VectorOperators.Divide, ScalarOperators.Divide);
    }
}