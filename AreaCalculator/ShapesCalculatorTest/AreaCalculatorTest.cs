using NUnit.Framework;
using ShapesCalculator;
using System;

namespace ShapesCalculatorTest
{
    [TestFixture]
    public class AreaCalculatorTest
    {
        private AreaCalculator Calculator;

        [SetUp]
        protected void SetUp()
        {
            Calculator = new();
        }

        [Test]
        [DefaultFloatingPointTolerance(1e-5)]
        [TestCase(15, ExpectedResult = 706.85834703)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 3.1415926535)]
        public double CorrectCircleTest(double r)
        {
            return Calculator.CalculateArea(r);
        }

        [Test]
        public void NegativeCircleTest()
        {
            Assert.Throws<ArgumentException>(() => Calculator.CalculateArea(-10));
        }

        [Test]
        [DefaultFloatingPointTolerance(1e-5)]
        [TestCase(3, 4, 5, ExpectedResult = 6)]
        [TestCase(15, 10, 12, ExpectedResult = 59.81168364124187)]
        [TestCase(0, 0, 0, ExpectedResult = 0)]
        public double CorrectTriangleTest(double a, double b, double c)
        {
            return Calculator.CalculateArea(a, b, c);
        }

        [Test]
        public void NegativeTriangleTest()
        {
            Assert.Throws<ArgumentException>(() => Calculator.CalculateArea(1, -10, 0));
        }

    }
}