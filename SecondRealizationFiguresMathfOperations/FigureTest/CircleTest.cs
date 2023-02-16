using FiguresMathfOperations.Domain.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

namespace FigureTest
{
    [TestClass]
    public class CircleTest
    {
        private Circle circleToTest;

        [TestInitialize]
        public void TestInitializate()
        {
            circleToTest = new Circle(1);
        }

        [TestMethod]
        public void IsCurrectCalclulateAreaOfCircle_Pi()
        {
            Assert.AreEqual(Math.PI, circleToTest.CalculateArea(), "Error calculate radius value");
        }
    }
}
