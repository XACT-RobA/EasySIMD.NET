using System;
using Xunit;
using EasySIMD.NET;

namespace EasySIMD.NET.Test
{
    public class BasicMathsExtensionsFloatingPointTests
    {
        private static readonly int precision = 8;

        private static readonly float[] _floatBase = new[] { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f, 6.0f, 7.0f, 8.0f, 9.0f, 10.0f };
        private static readonly float[] _floatOnes = new[] { 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f };
        private static readonly float[] _floatTwos = new[] { 2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f };

        private static readonly double[] _doubleBase = new[] { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0 };
        private static readonly double[] _doubleOnes = new[] { 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0 };
        private static readonly double[] _doubleTwos = new[] { 2.0, 2.0, 2.0, 2.0, 2.0, 2.0, 2.0, 2.0, 2.0, 2.0 };

        // Add

        [Fact]
        public void TestAddFloat()
        {
            var actual = _floatBase.Add(_floatBase);
            var expected = new[] { 2.0f, 4.0f, 6.0f, 8.0f, 10.0f, 12.0f, 14.0f, 16.0f, 18.0f, 20.0f };

            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i], precision);
            }
        }

        [Fact]
        public void TestAddDouble()
        {
            var actual = _doubleBase.Add(_doubleBase);
            var expected = new[] { 2.0, 4.0, 6.0, 8.0, 10.0, 12.0, 14.0, 16.0, 18.0, 20.0 };
            
            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i], precision);
            }
        }

        // Subtract

        [Fact]
        public void TestSubtractFloat()
        {
            var actual = _floatBase.Subtract(_floatOnes);
            var expected = new[] { 0.0f, 1.0f, 2.0f, 3.0f, 4.0f, 5.0f, 6.0f, 7.0f, 8.0f, 9.0f };

            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i], precision);
            }
        }

        [Fact]
        public void TestSubtractDouble()
        {
            var actual = _doubleBase.Subtract(_doubleOnes);
            var expected = new[] { 0.0, 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0 };
            
            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i], precision);
            }
        }

        // Multiply

        [Fact]
        public void TestMultiplyFloat()
        {
            var actual = _floatBase.Multiply(_floatTwos);
            var expected = new[] { 2.0f, 4.0f, 6.0f, 8.0f, 10.0f, 12.0f, 14.0f, 16.0f, 18.0f, 20.0f };

            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i], precision);
            }
        }

        [Fact]
        public void TestMultiplyDouble()
        {
            var actual = _doubleBase.Multiply(_doubleTwos);
            var expected = new[] { 2.0, 4.0, 6.0, 8.0, 10.0, 12.0, 14.0, 16.0, 18.0, 20.0 };
            
            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i], precision);
            }
        }

        // Divide

        [Fact]
        public void TestDivideFloat()
        {
            var actual = _floatBase.Divide(_floatTwos);
            var expected = new[] { 0.5f, 1.0f, 1.5f, 2.0f, 2.5f, 3.0f, 3.5f, 4.0f, 4.5f, 5.0f };
            
            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i], precision);
            }
        }

        [Fact]
        public void TestDivideDouble()
        {
            var actual = _doubleBase.Divide(_doubleTwos);
            var expected = new[] { 0.5, 1.0, 1.5, 2.0, 2.5, 3.0, 3.5, 4.0, 4.5, 5.0 };
            
            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i], precision);
            }
        }
    }
}
