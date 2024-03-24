using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureLib.Test
{
    [TestFixture]
    public class CirlceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(nameof(ZeroOrNegativeCirlceRadius))]
        public void ZeroOrNegaitveCircleSidesTest(double radius)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new Circle(radius);
            });

        }

        public static object[] ZeroOrNegativeCirlceRadius =
        {
            -100, -24.5, 0
        };
    }
}
