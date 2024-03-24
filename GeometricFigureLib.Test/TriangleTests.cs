using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureLib.Test
{
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [TestCaseSource(nameof(ZeroOrNegativeTriangleSides))]
        public void ZeroOrNegaitveTriangleSidesTest(double[] sides)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new Triangle(sides[0], sides[1], sides[2]);
            });
        }

        [TestCaseSource(nameof(NotCorrectTriangleSides))]
        public void NotCorrectTriangleSidesTest(double[] sides)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new Triangle(sides[0], sides[1], sides[2]);
            });
        }

        [TestCaseSource(nameof(RightTriangles))]
        public void TriangleIsRightTest(Triangle triangle)
        {
            Assert.That(triangle.IsRightTriangle(), Is.True);
        }

        [TestCaseSource(nameof(NormalTriangles))]
        public void TriangleIsCorrectAndNotRightTest(double[] sides)
        {
            Assert.That(() =>
            {
                var t = new Triangle(sides[0], sides[1], sides[2]);
                return !t.IsRightTriangle();
            }, Is.True);
        }

        public static object[] NotCorrectTriangleSides =
        {
            new double[] { 1, 4, 10 },
            new double[] { 2, 4, 100 },
            new double[] { 50, 49, 1 }
        };

        public static object[] ZeroOrNegativeTriangleSides =
        {
            new double[] { 1, 4, -3 },
            new double[] { 1, -2, -3 },
            new double[] { -1, -2, -3 },
            new double[] { 1, 2, 0 }
        };

        public static Triangle[] RightTriangles =
        {
            new Triangle (3, 4, 5),
            new Triangle (6, 8, 10),
            new Triangle (9, 12, 15)
        };

        public static object[] NormalTriangles =
        {
            new double[] { 3, 7, 8 },
            new double[] { 8, 15, 10 },
            new double[] { 20, 5, 23 }
        };
    }
}
