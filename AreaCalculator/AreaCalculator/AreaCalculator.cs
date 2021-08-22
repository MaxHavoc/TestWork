using System;

namespace ShapesCalculator
{
    public class AreaCalculator
    {
        /// <summary>
        /// Calculate circle area, throw exception if radius is negative
        /// </summary>
        public double CalculateArea(double radius)
        {
            return CalculateCircleArea(radius);
        }

        /// <summary>
        /// Calculate triangle area, throw exception if side is negative
        /// </summary>
        public double CalculateArea(double a, double b, double c)
        {
            return CalculteTriangleArea(a, b, c);
        }

        public double CalculateCircleArea(double radius)
        {
            if (radius < 0) throw new ArgumentException("Negative radius");
            return Math.PI * radius * radius;
        }

        public double CalculteTriangleArea(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0) throw new ArgumentException("Negative triangle side");
            var p = (a + b + c) / 2;
            return Math.Pow(p * (p - a) * (p - b) * (p - c), 0.5);
        }

    }
}
