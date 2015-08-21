using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UnitTest
{
    [TestClass]
    public class UnitTestClassLibrary
    {
        [TestMethod]
        public void CalculateAreaRightTriangle()
        {
            RightTriangle rt = new RightTriangle(3, 4, 5);
            decimal area = rt.CalculateArea();
            Assert.AreEqual(area, 6);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleExeption))]
        public void IsNotTriangleExeption()
        {
            RightTriangle rt = new RightTriangle(3, 2, 5);
        }

        [TestMethod]
        public void AreasEqualTriangles()
        {
            RightTriangle rt1 = new RightTriangle(3, 5, 4);
            RightTriangle rt2 = new RightTriangle(5, 4, 3);
            decimal area1 = rt1.CalculateArea();
            decimal area2 = rt2.CalculateArea();

            // Убеждаемся что это площадь одного и того же треугольника
            Assert.AreEqual(area1, area2);
        }
    }
}
