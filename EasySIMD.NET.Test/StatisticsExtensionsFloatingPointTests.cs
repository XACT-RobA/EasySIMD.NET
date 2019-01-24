using System;
using Xunit;
using EasySIMD.NET;

namespace EasySIMD.NET.Test
{
    public class StatisticsExtensionsFloatingPointTests
    {
        private static int precision = 8;

        // Sum

        [Fact]
        public void TestSumFloat()
        {
            var input = new[] { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f, 6.0f, 7.0f, 8.0f, 9.0f, 10.0f };

            var actual = input.Sum();
            var expected = 55.0f;

            Assert.Equal(expected, actual, precision);
        }

        [Fact]
        public void TestSumDouble()
        {
            var input = new[] { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0 };

            var actual = input.Sum();
            var expected = 55.0;

            Assert.Equal(expected, actual, precision);
        }

        // Product

        [Fact]
        public void TestProductFloat()
        {
            var input = new[] { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f, 6.0f, 7.0f, 8.0f, 9.0f, 10.0f };

            var actual = input.Product();
            var expected = 3628800.0f;

            Assert.Equal(expected, actual, precision);
        }

        [Fact]
        public void TestProductDouble()
        {
            var input = new[] { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0 };

            var actual = input.Product();
            var expected = 3628800.0;

            Assert.Equal(expected, actual, precision);
        }
    }
}
