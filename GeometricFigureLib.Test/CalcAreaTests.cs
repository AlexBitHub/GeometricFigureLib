using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureLib.Test
{
    [TestFixture]
    public class CalcAreaTests
    {
        public CalcAreaTests()
        {
        }

        [TestCaseSource(nameof(FiguresAreasList))]
        public void CalcArea((IFigure, double) figureAndArea)
        {
            var calcArea = figureAndArea.Item1.GetArea();
            Assert.That(calcArea, Is.EqualTo(figureAndArea.Item2).Within(0.01));            
        }


        public static List<(IFigure, double)> FiguresAreasList = new()
        {
            (new Triangle (3, 4, 5), 6),
            (new Triangle (15, 5, 11), 19.136),
            (new Circle (9), 254.469),
            (new Circle (5.5), 95.033),
        };
    }
}
