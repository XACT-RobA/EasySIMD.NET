using System;
using Xunit;
using EasySIMD.NET;

namespace EasySIMD.NET.Test
{
    public class StatisticsExtensionsIntegerTests
    {
        [Fact]
        public void TestSumShort()
        {
            var input = new short[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            var actual = input.Sum();
            var expected = 210;

            Assert.Equal(expected, actual);
        }
    }
}
