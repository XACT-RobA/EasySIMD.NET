using System;
using Xunit;
using EasySIMD.NET;

namespace EasySIMD.NET.Test
{
    public class MatrixExtensionsIntegerTests
    {
        [Fact]
        public void TestDotProductShort()
        {
            var left = new short[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            var right = new short[] { 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            var actual = left.DotProduct(right);
            var expected = 1330;

            Assert.Equal(expected, actual);
        }
    }
}