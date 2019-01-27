namespace EasySIMD.NET
{
    public static class MatrixExtensions
    {
        public static short DotProduct(this short[] left, short[] right) => left.Multiply(right).Sum();
    }
}