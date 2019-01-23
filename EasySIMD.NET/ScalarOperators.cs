using System;

namespace EasySIMD.NET
{
    public static class ScalarOperators
    {
        // Add
        public static short Add(short left, short right) => (short)(left + right);
        public static int Add(int left, int right) => left + right;
        public static long Add(long left, long right) => left + right;
        public static float Add(float left, float right) => left + right;
        public static double Add(double left, double right) => left + right;

        // Subtract
        public static short Subtract(short left, short right) => (short)(left - right);
        public static int Subtract(int left, int right) => left - right;
        public static long Subtract(long left, long right) => left - right;
        public static float Subtract(float left, float right) => left - right;
        public static double Subtract(double left, double right) => left - right;

        // Multiply
        public static short Multiply(short left, short right) => (short)(left * right);
        public static int Multiply(int left, int right) => left * right;
        public static long Multiply(long left, long right) => left * right;
        public static float Multiply(float left, float right) => left * right;
        public static double Multiply(double left, double right) => left * right;

        // Divide
        public static short Divide(short left, short right) => (short)(left / right);
        public static int Divide(int left, int right) => left / right;
        public static long Divide(long left, long right) => left / right;
        public static float Divide(float left, float right) => left / right;
        public static double Divide(double left, double right) => left / right;
    }
}