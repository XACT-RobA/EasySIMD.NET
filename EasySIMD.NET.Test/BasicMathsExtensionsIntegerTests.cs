using System;
using Xunit;
using EasySIMD.NET;

namespace EasySIMD.NET.Test
{
    public class BasicMathsExtensionsIntegerTests
    {
        // Add

        [Fact]
        public void TestAddShort()
        {
            var left = new short[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            var right = new short[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            var expected = new short[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40 };

            var actual = left.Add(right);

            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void TestAddInt()
        {
            var left = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var right = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var expected = new[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            var actual = left.Add(right);

            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void TestAddLong()
        {
            var left = new[] { 1L, 2L, 3L, 4L, 5L, 6L, 7L, 8L, 9L, 10L };
            var right = new[] { 1L, 2L, 3L, 4L, 5L, 6L, 7L, 8L, 9L, 10L };

            var expected = new[] { 2L, 4L, 6L, 8L, 10L, 12L, 14L, 16L, 18L, 20L };

            var actual = left.Add(right);

            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        // Subtract

        [Fact]
        public void TestSubtractShort()
        {
            var left = new short[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            var right = new short[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            var expected = new short[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

            var actual = left.Subtract(right);

            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void TestSubtractInt()
        {
            var left = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var right = new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            var expected = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var actual = left.Subtract(right);

            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void TestSubtractLong()
        {
            var left = new[] { 1L, 2L, 3L, 4L, 5L, 6L, 7L, 8L, 9L, 10L };
            var right = new[] { 1L, 1L, 1L, 1L, 1L, 1L, 1L, 1L, 1L, 1L };

            var expected = new[] { 0L, 1L, 2L, 3L, 4L, 5L, 6L, 7L, 8L, 9L };

            var actual = left.Subtract(right);

            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        // Multiply

        [Fact]
        public void TestMultiplyShort()
        {
            var left = new short[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            var right = new short[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };

            var expected = new short[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40 };

            var actual = left.Multiply(right);

            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void TestMultiplyInt()
        {
            var left = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var right = new[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };

            var expected = new[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            var actual = left.Multiply(right);

            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void TestMultiplyLong()
        {
            var left = new[] { 1L, 2L, 3L, 4L, 5L, 6L, 7L, 8L, 9L, 10L };
            var right = new[] { 2L, 2L, 2L, 2L, 2L, 2L, 2L, 2L, 2L, 2L };

            var expected = new[] { 2L, 4L, 6L, 8L, 10L, 12L, 14L, 16L, 18L, 20L };

            var actual = left.Multiply(right);

            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        // Divide

        [Fact]
        public void TestDivideShort()
        {
            var left = new short[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            var right = new short[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };

            var expected = new short[] { 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10 };

            var actual = left.Divide(right);

            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void TestDivideInt()
        {
            var left = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var right = new[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };

            var expected = new[] { 0, 1, 1, 2, 2, 3, 3, 4, 4, 5 };

            var actual = left.Divide(right);

            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void TestDivideLong()
        {
            var left = new[] { 1L, 2L, 3L, 4L, 5L, 6L, 7L, 8L, 9L, 10L };
            var right = new[] { 2L, 2L, 2L, 2L, 2L, 2L, 2L, 2L, 2L, 2L };

            var expected = new[] { 0L, 1L, 1L, 2L, 2L, 3L, 3L, 4L, 4L, 5L };

            var actual = left.Divide(right);

            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }
    }
}