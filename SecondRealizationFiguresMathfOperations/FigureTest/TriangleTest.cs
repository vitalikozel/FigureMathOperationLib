using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FiguresMathfOperations.Domain;
using FiguresMathfOperations.Domain.Figures;
using System.Text;
using System.Diagnostics;

namespace FigureTest
{
    [TestClass]
    public class TriangleTest
    {
        private Triangle triangle;
        private Triangle triangleNotRectangle;

        [TestInitialize]
        public void TestInitiallize()
        {
            triangle = new Triangle(new double[] { 24, 25, 7 });
            triangleNotRectangle = new Triangle(new double[] { 5, 4, 4 });
        }

        [TestMethod]
        public void CalculateAreaTest()
        {
            double aSide = 24;
            double bSide = 25;
            double cSide = 7;

            double parametr = (aSide + bSide + cSide) / 2;
            double area = Math.Sqrt(parametr * (parametr - aSide) * (parametr - bSide) * (parametr - cSide));

            Assert.AreEqual(area, triangle.CalculateArea());
        }

        [TestMethod]
        public void IsRectangleTest()
        {
            Assert.IsTrue(triangle.IsRectangle());
        }

        [TestMethod]
        public void IsNotRectangleTest()
        {
            Assert.IsFalse(triangleNotRectangle.IsRectangle());
        }
    }
}
