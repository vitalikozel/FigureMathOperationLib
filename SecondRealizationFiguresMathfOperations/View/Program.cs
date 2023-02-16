using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguresMathfOperations.Domain.Figures;
using FiguresMathfOperations.Domain.Interface.Figure;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(new double[] { 24, 25, 7});
            Console.WriteLine($"{triangle.CalculateArea()}, isrectangle: {triangle.IsRectangle()}");

            IFigure circle = new Circle(1);
            Console.WriteLine($"{circle.CalculateArea()}");

            Console.ReadLine();
        }
    }
}
