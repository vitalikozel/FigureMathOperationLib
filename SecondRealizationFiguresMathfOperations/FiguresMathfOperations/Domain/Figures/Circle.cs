using FiguresMathfOperations.Domain.Interface.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresMathfOperations.Domain.Figures
{
    public class Circle : IFigure
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            if(IsCurrentSetRadius() == false)
            {
                throw new ArgumentException("Error radius of circle", nameof(_radius));
            }

            return Math.PI * Math.Pow(_radius, 2);
        }

        private bool IsCurrentSetRadius()
        {
            if(_radius > 0)
            {
                return true;
            }

            return false;
        }
    }
}
