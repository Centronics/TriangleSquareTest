using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleSquareTest
{
    [TestClass]
    public class TriangleSquareTest1
    {
        [TestMethod]
        public void TestMethodTriangleSquare()
        {
            double expected = 693.0, actual = Triangle.Triangle.TriangleSquare(12.0, 115.5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethodTriangleSquareExpt()
        {
            Triangle.Triangle.TriangleSquare(-12.0, 115.5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethodTriangleSquareExpt1()
        {
            Triangle.Triangle.TriangleSquare(0.0, -115.5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethodTriangleSquareExpt2()
        {
            Triangle.Triangle.TriangleSquare(12.0, -115.5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethodTriangleSquareExpt3()
        {
            Triangle.Triangle.TriangleSquare(-115.5, 0.0);
        }
    }
}