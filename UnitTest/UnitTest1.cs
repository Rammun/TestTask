using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateAreaRightTriangle()
        {
            RightTriangle rt = new RightTriangle(3, 4, 5);
            double area = rt.CalculateArea();
            Assert.AreEqual(area, 6);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleExeption))]
        public void IsNotTriangleExeption()
        {
            RightTriangle rt = new RightTriangle(3, 2, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleExeption))]
        public void NotCorrectParamRightTriangleExeption()
        {
            RightTriangle rt = new RightTriangle(3, 5, 4);
        }
    }
}
