using System;
using System.Numerics;

namespace EasySIMD.NET
{
    public static class StatisticsExtensions
    {
        // Sum

        public static short Sum(this short[] input)
        {
            var simdLength = CommonSIMD.SimdLength<short>();
            var simdRange = input.Length - simdLength;
            var running = new Vector<short>(0);

            int i;
            for (i = 0; i <= simdRange; i+= simdLength)
            {
                var vinput = new Vector<short>(input, i);
                running += vinput;
            }

            short output = 0;

            for (int j = 0; j < simdLength; j++)
            {
                output += running[j];
            }

            for (; i < input.Length; i++)
            {
                output += input[i];
            }

            return output;
        }
    }
}
