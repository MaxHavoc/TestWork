using NUnit.Framework;
using ShapesCalculator;
using System;

namespace ShapesCalculatorTest
{
    [TestFixture]
    public class TriangleTypeCheckerTest
    {
        private TriangleTypeChecker Checker;

        [SetUp]
        protected void SetUp()
        {
            Checker = new();
        }

        [Test]
        [TestCase(3,4,5, ExpectedResult = true)]
        [TestCase(2,6,2, ExpectedResult = false)]
        public bool CorrectTest(double a, double b, double c)
        {
            return Checker.IsRight(a, b, c);
        }

        [Test]
        public void NegativeTest()
        {
            Assert.Throws<ArgumentException>(() => Checker.IsRight(5, -1, 1));
        }
    }
}