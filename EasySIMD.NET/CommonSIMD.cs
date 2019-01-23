using System;
using System.Numerics;

namespace EasySIMD.NET
{
    internal static class CommonSIMD
    {
        public static int SimdLength<T>()
            where T : struct
        {
            return Vector<T>.Count;
        }

        public static T[] Map<T>(this T[] left,T[] right,
            Func<Vector<T>, Vector<T>, Vector<T>> vectorOperator,
            Func<T, T, T> scalarOperator)
            where T : struct
        {
            var simdLength = SimdLength<T>();
            var simdRange = left.Length - simdLength;
            var output = new T[left.Length];

            int i;
            for (i = 0; i <= simdRange; i+= simdLength)
            {
                var vleft = new Vector<T>(left, i);
                var vright = new Vector<T>(right, i);
                vectorOperator(vleft, vright).CopyTo(output, i);
            }

            for (; i < left.Length; i++)
            {
                output[i] = scalarOperator(left[i], right[i]);
            }

            return output;
        }

        public static T Reduce<T>(this T[] input,
            Func<Vector<T>, Vector<T>, Vector<T>> vectorOperator,
            Func<T, T, T> scalarOperator,
            T defaultValue = default(T))
            where T : struct
        {
            var simdLength = SimdLength<T>();
            var simdRange = input.Length - simdLength;
            var running = new Vector<T>(defaultValue);

            int i;
            for (i = 0; i <= simdRange; i += simdLength)
            {
                var vinput = new Vector<T>(input, i);
                running = vectorOperator(running, vinput);
            }

            var output = defaultValue;

            for (int j = 0; j < simdLength; j++)
            {
                output = scalarOperator(output, running[j]);
            }

            for (; i < input.Length; i++)
            {
                output = scalarOperator(output, input[i]);
            }

            return output;
        }
    }
}
