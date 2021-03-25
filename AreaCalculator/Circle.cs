using System;
namespace AreaCalculator
{
    //Расчет площади круга
    public class Circle : Figure
    {
        const double pi = Math.PI;
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return pi * Math.Pow(this.radius, 2);
        }
    }
}
