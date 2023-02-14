using System;

namespace FiguresMathfOperations.Figures.FiguresType
{
    public class Triangle : Figure
    {
        private double[] _sizeSides;

        public Triangle(double[] sidesSize)
        {
            _sizeSides = sidesSize;
        }

        public override double CalculateArea()
        {
            double p = GetSumSizeSides() / 2;
            double s = p;

            for (int i = 0; i < _sizeSides.Length; i++)
            {
                s = s * (p - _sizeSides[i]);
            }

            return Math.Sqrt(s);
        }

        public bool IsRectangular()
        {
            double tallesSizeSide = _sizeSides[GetIndexHighlestSide()];
            double sumOtherSides = GetPowSumSidesWithOutMaxSide();

            if(Math.Pow(tallesSizeSide, 2) == sumOtherSides)
            {
                return true;
            }

            return false;
        }

        private double GetPowSumSidesWithOutMaxSide()
        {
            double sum = 0;
            int indexMaxSide = GetIndexHighlestSide();

            for (int i = 0; i < _sizeSides.Length; i++)
            {
                if(i != indexMaxSide)
                {
                    sum += Math.Pow(_sizeSides[i], 2);
                }
            }

            return sum;
        }

        private int GetIndexHighlestSide()
        {
            int maxValueIndex = 0;

            for (int i = 0; i < _sizeSides.Length; i++)
            {
                if (_sizeSides[i] > _sizeSides[maxValueIndex])
                {
                    maxValueIndex = i;
                }
            }

            return maxValueIndex;
        }

        private double GetSumSizeSides()
        {
            double sum = 0;

            for (int i = 0; i < _sizeSides.Length; i++)
            {
                sum += _sizeSides[i];
            }

            return sum;
        } 
    }
}
