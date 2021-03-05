using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Triangle;

namespace TriangleTest
{
    [TestFixture]
    public class TriangleTest
    {

        [Test]
        public void checkEquilateralTriangle()
        {
            Assert.AreEqual(TriangleSolution.TriangleAnalyze(10, 10, 10), "Equilateral Triangle");

        }
        [Test]
        public void checkIsoTriangle()
        {
            Assert.AreEqual(TriangleSolution.TriangleAnalyze(10, 10, 15), "Isosceles Triangle");

        }
        [Test]
        public void checkScaleneTriangle()
        {
            Assert.AreEqual(TriangleSolution.TriangleAnalyze(10, 15, 20), "Scalene Triangle");

        }
        [Test]
        public void checkRecognozeTriangle_2410()
        {
            Assert.AreEqual(TriangleSolution.TriangleAnalyze(2, 4, 10), "Not Recognized");

        }
        [Test]
        public void checkRecognozeTriangle_01020()
        {
            Assert.AreEqual(TriangleSolution.TriangleAnalyze(0, 10, 20), "Not Recognized (Side < 0)");

        }
        [Test]
        public void checkRecognozeTriangle_010minus10()
        {
            Assert.AreEqual(TriangleSolution.TriangleAnalyze(0, 10, -10), "Not Recognized (Side < 0)");

        }
        [Test]
        public void checkRecognozeTriangle_000()
        {
            Assert.AreEqual(TriangleSolution.TriangleAnalyze(0, 0, 0), "Not Recognized (Side < 0)");

        }
        [Test]
        public void checkRecognozeTriangle_minus101010()
        {
            Assert.AreEqual(TriangleSolution.TriangleAnalyze(-10, -10, -10), "Not Recognized (Side < 0)");

        }
    }
}
