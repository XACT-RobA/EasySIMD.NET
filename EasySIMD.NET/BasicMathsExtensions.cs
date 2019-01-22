using System;
using System.Numerics;

namespace EasySIMD.NET
{
    public static class BasicMathsExtensions
    {
        public static float[] Add(this float[] left, float[] right)
        {
            var simdLength = Vector<float>.Count;
            var simdRange = left.Length - simdLength;
            var output = new float[left.Length];

            int i;
            for (i = 0; i < simdRange; i+= simdLength)
            {
                var vleft = new Vector<float>(left, i);
                var vright = new Vector<float>(right, i);
                (vleft + vright).CopyTo(output, i);
            }

            for (; i < left.Length; i++)
            {
                output[i] = left[i] + right[i];
            }

            return output;
        }
    }
}