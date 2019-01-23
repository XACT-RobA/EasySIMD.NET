using System;
using System.Numerics;

namespace EasySIMD.NET
{
    public static class StatisticsExtensions
    {
        // Sum

        public static short Sum(this short[] input)
        {
            return input.Reduce(VectorOperators.Add, ScalarOperators.Add);
        }
    }
}
