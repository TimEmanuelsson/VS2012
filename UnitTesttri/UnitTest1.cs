using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesttri
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        public void isIsoscelestest()
        {
            Triangle tri = new Triangle(2.0, 2.0, 1.0);
            Assert.IsTrue(tri.isIsosceles());
            Assert.IsFalse(tri.isScalene());
            Assert.IsFalse(tri.isEquilateral());
        }

        [TestMethod]
        public void isEquilateraltest()
        {
            Triangle tri = new Triangle(3.0, 3.0, 3.0);
            Assert.IsTrue(tri.isEquilateral());
            Assert.IsFalse(tri.isIsosceles());
            Assert.IsFalse(tri.isScalene());
        }

        [TestMethod]
        public void isScalenetest()
        {
            Triangle tri = new Triangle(1.0, 2.0, 3.0);
            Assert.IsTrue(tri.isScalene());
            Assert.IsFalse(tri.isIsosceles());
            Assert.IsFalse(tri.isEquilateral());
        }
        [TestMethod]
        public void cortestisEquilateral()
        {
            Point a = new Point(3, 3);
            Point b = new Point(3, 3);
            Point c = new Point(3, 3);
            Triangle tri = new Triangle(a, b, c);
            Assert.IsTrue(tri.isEquilateral());
            Assert.IsFalse(tri.isIsosceles());
            Assert.IsFalse(tri.isScalene());
        }

        [TestMethod]
        public void cortestisScalene()
        {
            double[] coor;
            coor = new double[]{1.0, 2.0, 3.0};
            Triangle tri = new Triangle(coor);
            Assert.IsTrue(tri.isScalene());
            Assert.IsFalse(tri.isIsosceles());
            Assert.IsFalse(tri.isEquilateral());
        }

        [TestMethod]
        public void cortestisEquilateralarray()
        {
            
            Point a = new Point(3, 3);
            Point b = new Point(3, 3);
            Point c = new Point(3, 3);
            Point[] point;
            point = new Point[] { a, b, c };
            Triangle tri = new Triangle(point);
            Assert.IsTrue(tri.isEquilateral());
            Assert.IsFalse(tri.isIsosceles());
            Assert.IsFalse(tri.isScalene());
        }

        
    }
}
