using System;
using System.Numerics;

namespace EasySIMD.NET
{
    public static class StatisticsExtensions
    {
        // Sum

        public static short Sum(this short[] input) => input.Reduce(VectorOperators.Add, ScalarOperators.Add);
        public static int Sum(this int[] input) => input.Reduce(VectorOperators.Add, ScalarOperators.Add);
        public static long Sum(this long[] input) => input.Reduce(VectorOperators.Add, ScalarOperators.Add);

        // Product

        public static short Product(this short[] input) => input.Reduce(VectorOperators.Multiply, ScalarOperators.Multiply, (short)1);
        public static int Product(this int[] input) => input.Reduce(VectorOperators.Multiply, ScalarOperators.Multiply, 1);
        public static long Product(this long[] input) => input.Reduce(VectorOperators.Multiply, ScalarOperators.Multiply, 1L);
    }
}
