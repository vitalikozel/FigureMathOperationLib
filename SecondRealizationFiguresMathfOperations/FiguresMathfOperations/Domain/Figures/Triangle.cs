using FiguresMathfOperations.Domain.Interface.CustomFigures;
using System;

namespace FiguresMathfOperations.Domain.Figures
{
    public class Triangle : ITriangle
    {
        public double[] _sides { get; set; }

        public Triangle(double[] sidesSize)
        {
            _sides = sidesSize;
        }

        public double CalculateArea()
        {
            IsCurrectSidesSize();

            double p = GetSumSizeSides() / 2;
            double s = p;

            for (int i = 0; i < _sides.Length; i++)
            {
                s = s * (p - _sides[i]);
            }

            return Math.Sqrt(s);
        }

        public bool IsRectangle()
        {
            IsCurrectSidesSize();

            double tallesSizeSide = _sides[GetIndexHighlestSide()];
            double sumOtherSides = GetPowSumSidesWithOutMaxSide();

            if (Math.Pow(tallesSizeSide, 2) == sumOtherSides)
            {
                return true;
            }

            return false;
        }

        private bool IsCurrectSidesSize()
        {
            if(_sides.Length - 1 >= 3)
            {
                throw new ArgumentException("Triangle cant have more after 3 sides");
            }

            if (_sides.Length == 0)
            {
                throw new ArgumentException("U cant calculate area of traingle without sides");
            }

            for (int i = 0; i < _sides.Length; i++)
            {
                if (_sides[i] <= 0)
                {
                    throw new ArgumentException("Error size side");
                }
            }

            double tallesSizeSide = _sides[GetIndexHighlestSide()];
            double sumOtherSidesSize = GetSumSidesWithOutMaxSide();

            if(tallesSizeSide > sumOtherSidesSize) 
            {
                throw new ArgumentException("Sum size two side can not be bigger than size talles side");
            }

            return true;
        }

        private double GetSumSidesWithOutMaxSide()
        {
            double sum = 0;
            int indexMaxSide = GetIndexHighlestSide();

            for (int i = 0; i < _sides.Length; i++)
            {
                if (i != indexMaxSide)
                {
                    sum += _sides[i];
                }
            }

            return sum;
        }

        private double GetPowSumSidesWithOutMaxSide()
        {
            double sum = 0;
            int indexMaxSide = GetIndexHighlestSide();

            for (int i = 0; i < _sides.Length; i++)
            {
                if (i != indexMaxSide)
                {
                    sum += Math.Pow(_sides[i], 2);
                }
            }

            return sum;
        }

        private int GetIndexHighlestSide()
        {
            int maxValueIndex = 0;

            for (int i = 0; i < _sides.Length; i++)
            {
                if (_sides[i] > _sides[maxValueIndex])
                {
                    maxValueIndex = i;
                }
            }

            return maxValueIndex;
        }

        private double GetSumSizeSides()
        {
            double sum = 0;

            for (int i = 0; i < _sides.Length; i++)
            {
                sum += _sides[i];
            }

            return sum;
        }
    }
}
