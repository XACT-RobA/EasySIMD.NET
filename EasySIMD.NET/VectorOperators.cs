using System;
using System.Numerics;

namespace EasySIMD.NET
{
    public static class VectorOperators
    {
        public static Vector<T> Add<T>(Vector<T> left, Vector<T> right) where T : struct => left + right;
        public static Vector<T> Subtract<T>(Vector<T> left, Vector<T> right) where T : struct => left - right;
        public static Vector<T> Multiply<T>(Vector<T> left, Vector<T> right) where T : struct => left * right;
        public static Vector<T> Divide<T>(Vector<T> left, Vector<T> right) where T : struct => left / right;
    }
}