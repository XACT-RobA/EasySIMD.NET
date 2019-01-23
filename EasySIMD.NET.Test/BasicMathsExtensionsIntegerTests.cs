using System;
using Xunit;
using EasySIMD.NET;

namespace EasySIMD.NET.Test
{
    public class BasicMathsExtensionsIntegerTests
    {
        private static readonly short[] _shortBase = new short[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        private static readonly short[] _shortOnes = new short[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        private static readonly short[] _shortTwos = new short[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };

        private static readonly int[] _intBase = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private static readonly int[] _intOnes = new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        private static readonly int[] _intTwos = new[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };

        private static readonly long[] _longBase = new[] { 1L, 2L, 3L, 4L, 5L, 6L, 7L, 8L, 9L, 10L };
        private static readonly long[] _longOnes = new[] { 1L, 1L, 1L, 1L, 1L, 1L, 1L, 1L, 1L, 1L };
        private static readonly long[] _longTwos = new[] { 2L, 2L, 2L, 2L, 2L, 2L, 2L, 2L, 2L, 2L };

        // Add

        [Fact]
        public void TestAddShort()
        {
            var actual = _shortBase.Add(_shortBase);
            var expected = new short[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40 };
            
            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void TestAddInt()
        {
            var actual = _intBase.Add(_intBase);
            var expected = new[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            
            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void TestAddLong()
        {
            var actual = _longBase.Add(_longBase);
            var expected = new[] { 2L, 4L, 6L, 8L, 10L, 12L, 14L, 16L, 18L, 20L };
            
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
            var actual = _shortBase.Subtract(_shortOnes);
            var expected = new short[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            
            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void TestSubtractInt()
        {
            var actual = _intBase.Subtract(_intOnes);
            var expected = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void TestSubtractLong()
        {
            var actual = _longBase.Subtract(_longOnes);
            var expected = new[] { 0L, 1L, 2L, 3L, 4L, 5L, 6L, 7L, 8L, 9L };
            
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
            var actual = _shortBase.Multiply(_shortTwos);
            var expected = new short[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40 };
            
            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void TestMultiplyInt()
        {
            var actual = _intBase.Multiply(_intTwos);
            var expected = new[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            
            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void TestMultiplyLong()
        {
            var actual = _longBase.Multiply(_longTwos);
            var expected = new[] { 2L, 4L, 6L, 8L, 10L, 12L, 14L, 16L, 18L, 20L };
            
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
            var actual = _shortBase.Divide(_shortTwos);
            var expected = new short[] { 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10 };
            
            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void TestDivideInt()
        {
            var actual = _intBase.Divide(_intTwos);
            var expected = new[] { 0, 1, 1, 2, 2, 3, 3, 4, 4, 5 };
            
            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void TestDivideLong()
        {
            var actual = _longBase.Divide(_longTwos);
            var expected = new[] { 0L, 1L, 1L, 2L, 2L, 3L, 3L, 4L, 4L, 5L };
            
            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }
    }
}