using System;
using System.Numerics;

namespace EasySIMD.NET
{
    public static class BasicMathsExtensions
    {
        // Add
        public static short[] Add(this short[] left, short[] right)
            => left.Map(right, VectorOperators.Add, ScalarOperators.Add);
        public static int[] Add(this int[] left, int[] right)
            => left.Map(right, VectorOperators.Add, ScalarOperators.Add);
        public static long[] Add(this long[] left, long[] right)
            => left.Map(right, VectorOperators.Add, ScalarOperators.Add);
        public static float[] Add(this float[] left, float[] right)
            => left.Map(right, VectorOperators.Add, ScalarOperators.Add);
        public static double[] Add(this double[] left, double[] right)
            => left.Map(right, VectorOperators.Add, ScalarOperators.Add);

        // Subtract
        public static short[] Subtract(this short[] left, short[] right)
            => left.Map(right, VectorOperators.Subtract, ScalarOperators.Subtract);
        public static int[] Subtract(this int[] left, int[] right)
            => left.Map(right, VectorOperators.Subtract, ScalarOperators.Subtract);
        public static long[] Subtract(this long[] left, long[] right)
            => left.Map(right, VectorOperators.Subtract, ScalarOperators.Subtract);
        public static float[] Subtract(this float[] left, float[] right)
            => left.Map(right, VectorOperators.Subtract, ScalarOperators.Subtract);
        public static double[] Subtract(this double[] left, double[] right)
            => left.Map(right, VectorOperators.Subtract, ScalarOperators.Subtract);

        // Multiply
        public static short[] Multiply(this short[] left, short[] right)
            => left.Map(right, VectorOperators.Multiply, ScalarOperators.Multiply);
        public static int[] Multiply(this int[] left, int[] right)
            => left.Map(right, VectorOperators.Multiply, ScalarOperators.Multiply);
        public static long[] Multiply(this long[] left, long[] right)
            => left.Map(right, VectorOperators.Multiply, ScalarOperators.Multiply);
        public static float[] Multiply(this float[] left, float[] right)
            => left.Map(right, VectorOperators.Multiply, ScalarOperators.Multiply);
        public static double[] Multiply(this double[] left, double[] right)
            => left.Map(right, VectorOperators.Multiply, ScalarOperators.Multiply);

        // Divide
        public static short[] Divide(this short[] left, short[] right)
            => left.Map(right, VectorOperators.Divide, ScalarOperators.Divide);
        public static int[] Divide(this int[] left, int[] right)
            => left.Map(right, VectorOperators.Divide, ScalarOperators.Divide);
        public static long[] Divide(this long[] left, long[] right)
            => left.Map(right, VectorOperators.Divide, ScalarOperators.Divide);
        public static float[] Divide(this float[] left, float[] right)
            => left.Map(right, VectorOperators.Divide, ScalarOperators.Divide);
        public static double[] Divide(this double[] left, double[] right)
            => left.Map(right, VectorOperators.Divide, ScalarOperators.Divide);
    }
}