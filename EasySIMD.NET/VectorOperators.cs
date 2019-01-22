using System;
using System.Numerics;

namespace EasySIMD.NET
{
    public static class VectorOperators
    {
        // Add
        public static Vector<float> Add(Vector<float> left, Vector<float> right) => left + right;
        public static Vector<double> Add(Vector<double> left, Vector<double> right) => left + right;

        public static Vector<float> Subtract(Vector<float> left, Vector<float> right) => left - right;
        public static Vector<float> Multiply(Vector<float> left, Vector<float> right) => left * right;
        public static Vector<float> Divide(Vector<float> left, Vector<float> right) => left / right;
    }
}