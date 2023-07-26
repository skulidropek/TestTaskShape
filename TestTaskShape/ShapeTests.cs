using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestTaskShape
{

    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void CircleArea_CorrectRadius_ReturnsCorrectArea()
        {
            double radius = 5;
            Circle circle = new Circle(radius);

            double area = circle.CalculateArea();

            Assert.AreEqual(Math.PI * radius * radius, area, 0.001);
        }

        [Test]
        public void TriangleArea_CorrectSides_ReturnsCorrectArea()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            double area = triangle.CalculateArea();

            Assert.AreEqual(6, area, 0.001);
        }

        [Test]
        public void RightAngledTriangle_CheckRightAngled_ReturnsTrue()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            bool isRightAngled = triangle.IsRightAngledTriangle();

            Assert.IsTrue(isRightAngled);
        }

        [Test]
        public void NonRightAngledTriangle_CheckRightAngled_ReturnsFalse()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 6;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            bool isRightAngled = triangle.IsRightAngledTriangle();

            Assert.IsFalse(isRightAngled);
        }
    }
}
