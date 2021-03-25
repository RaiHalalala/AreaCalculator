using System;
using Xunit;

namespace AreaCalculator.Test
{
    public class AreaCalculatorTest
    {
        [Fact]
        public void CalculateArea_circle()
        {
            //arrange
            double r = 1;
            double result = 3.141592653589793;

            //act
            Circle circle = new Circle(r);
            double actual = circle.CalculateArea();

            //assept
            Assert.Equal(result, actual);

        }

        [Fact]
        public void CalculateArea_triangle()
        {
            //arrange
            double a = 2;
            double b = 3;
            double c = 4;
            double result = 2.9047375096555625;

            //act
            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.CalculateArea();

            //assept
            Assert.Equal(result, actual);

        }

        [Fact]
        public void testType_triangle()
        {
            //arrange
            double a = 5;
            double b = 3;
            double c = 4;
            string result = "Прямоугольный треугольник";

            //act
            Triangle triangle = new Triangle(a, b, c);
            string actual = triangle.TypeTriangle();

            //assept
            Assert.Equal(result, actual);

        }

        [Fact]
        public void CalculateArea_figure()
        {
            //arrange
            int[,] coord = { { 0, 1, 2 }, { 3, 4, 5 } };
            double result = 3;

            //act
            UnknownFigure unknownFigure = new UnknownFigure(coord);
            double actual = unknownFigure.CalculateArea();

            //assept
            Assert.Equal(result, actual);
        }

    }
}
