using System;

namespace EasySIMD.NET
{
    public static class ScalarOperators
    {
        // Add
        public static float Add(float left, float right) => left + right;
        public static double Add(double left, double right) => left + right;
        
        public static float Subtract(float left, float right) => left - right;
        public static float Multiply(float left, float right) => left * right;
        public static float Divide(float left, float right) => left / right;
    }
}