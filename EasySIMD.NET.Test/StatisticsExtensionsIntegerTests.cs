using System;
using Xunit;
using EasySIMD.NET;

namespace EasySIMD.NET.Test
{
    public class StatisticsExtensionsIntegerTests
    {
        // Sum

        [Fact]
        public void TestSumShort()
        {
            var input = new short[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            var actual = input.Sum();
            var expected = 210;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSumInt()
        {
            var input = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var actual = input.Sum();
            var expected = 55;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSumLong()
        {
            var input = new[] { 1L, 2L, 3L, 4L, 5L, 6L, 7L, 8L, 9L, 10L };

            var actual = input.Sum();
            var expected = 55L;

            Assert.Equal(expected, actual);
        }

        // Product

        [Fact]
        public void TestProductShort()
        {
            var input = new short[] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 };

            var actual = input.Product();
            var expected = 1024;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestProductInt()
        {
            var input = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var actual = input.Product();
            var expected = 3628800;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestProductLong()
        {
            var input = new[] { 1L, 2L, 3L, 4L, 5L, 6L, 7L, 8L, 9L, 10L };

            var actual = input.Product();
            var expected = 3628800L;

            Assert.Equal(expected, actual);
        }
    }
}
