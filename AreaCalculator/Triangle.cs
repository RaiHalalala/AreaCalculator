using System;
using System.Linq;

namespace AreaCalculator
{
    // расчет площади треугольника и вывод его типа
    public class Triangle : Figure
    {
        private double sideA;
        private double sideB;
        private double sideC;
        private double p;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.p = (sideA + sideB + sideC) / 2;
        }

        public override double CalculateArea()
        {
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));

        }
        public string TypeTriangle()
        {
            double[] arr = { this.sideA, this.sideB, this.sideC };
            double sum = 0;
            double maxValue = arr.Max();
            int maxIndex = arr.ToList().IndexOf(maxValue);
            Array.Clear(arr, maxIndex, 1);
            for (int i = 0; i < arr.Length; i++)
            {
                sum += Math.Pow(arr[i], 2);
            }

            if (Math.Pow(maxValue, 2) == sum)
            {
                return "Прямоугольный треугольник";
            }
            else
            {
                return "Треугольник не прямоугольный";
            }
        }
    }
}
