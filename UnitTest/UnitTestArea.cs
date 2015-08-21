using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Area;

namespace UnitTest
{
    [TestClass]
    public class UnitTestArea
    {
        [TestMethod]
        public void CalculateAreaRightTriangle()
        {
            decimal area = AreaFigure.AreaRightTriangle(3, 4, 5);
            Assert.AreEqual(area, 6);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void IsNotTriangleExeption()
        {
            decimal area = AreaFigure.AreaRightTriangle(5, 4, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void BadParamException()
        {
            decimal area = AreaFigure.AreaRightTriangle(-3, 4, 5);
        }

        [TestMethod]
        public void AreasEqualTriangles()
        {
            decimal area1 = AreaFigure.AreaRightTriangle(3, 4, 5);
            decimal area2 = AreaFigure.AreaRightTriangle(5, 4, 3);

            // Убеждаемся что это площадь одного и того же треугольника
            Assert.AreEqual(area1, area2);
        }
    }
}
