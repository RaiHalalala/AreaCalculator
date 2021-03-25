using System;
namespace AreaCalculator
{
    //расчет площади неизвестной фигуры с помощью координат
    public class UnknownFigure : Figure
    {
        private int[,] coord;
        public UnknownFigure(int[,] coord)
        {
            this.coord = coord;
        }
        public override double CalculateArea()
        {
            if (this.coord.Length == 2)
            {
                int sum1 = 0;
                int sum2 = 0;

                for (int i = 0; i < this.coord.GetLength(0) - 1; i++)
                {
                    sum1 += this.coord[0, i] * this.coord[1, i + 1];
                    sum2 += this.coord[1, i] * this.coord[0, i + 1];
                }

                double area = Math.Abs((sum1 - sum2) / 2d);
                return area;
            }
            else
            {
                throw new Exception("Что-то пошло не так");
            }

        }
    }
}
