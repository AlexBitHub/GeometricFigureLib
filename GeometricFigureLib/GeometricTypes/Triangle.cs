using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureLib.GeometricTypes
{
    public class Triangle : IFigure
    {
        private double _a;
        private double _b;
        private double _c;

        public Triangle(double a, double b, double c) 
        {
            IsTriangleExist(a, b, c);
        }
        public double GetArea()
        {
            var halfP = (_a + _b + _c) / 2;
            var temp = halfP + (halfP - _a) * (halfP - _b) * (halfP - _c); 
            return Math.Sqrt(temp);
        }

        public bool IsRightTriangle()
        {
            var sides = new List<double>(3) { _a, _b, _c };
            var hypotenuse = sides.Max();
            sides.Remove(hypotenuse);
            return hypotenuse * hypotenuse == (sides[0] * sides[0] + sides[0] * sides[0]);
        }

        public static void IsTriangleExist(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Сторона треугольника не может быть меньше или равна нулю.");
            }
            if (a + b <= c ||
                b + c <= a ||
                c + a <= b)
            {
                throw new ArgumentException("Треугольника с такими сторонами не существует.");
            }            
        }
    }
}
