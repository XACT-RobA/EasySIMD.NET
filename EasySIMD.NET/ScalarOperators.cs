using System;

namespace EasySIMD.NET
{
    public static class ScalarOperators
    {
        // Add
        public static float Add(float left, float right) => left + right;
        public static double Add(double left, double right) => left + right;

        // Subtract
        public static float Subtract(float left, float right) => left - right;
        public static double Subtract(double left, double right) => left - right;

        // Multiply
        public static float Multiply(float left, float right) => left * right;
        public static double Multiply(double left, double right) => left * right;

        // Divide
        public static float Divide(float left, float right) => left / right;
        public static double Divide(double left, double right) => left / right;
    }
}