using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesCalculator
{
    public class TriangleTypeChecker
    {
        public bool IsRight(double a, double b, double c, double e = 1e-15)
        {
            if (a < 0 || b < 0 || c < 0) throw new ArgumentException("Negative triangle side");

            if (Math.Abs(a * a - (b * b + c * c)) <= e
                || Math.Abs(b * b - (a * a + c * c)) <= e
                || Math.Abs(c * c - (a * a + b * b)) <= e) return true;
            else return false;
        }
    }
}
