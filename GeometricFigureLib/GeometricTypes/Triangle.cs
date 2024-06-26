﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureLib.GeometricTypes
{
    public class Triangle : IFigure
    {
        private double _a;
        private double _b;
        private double _c;

        public double A => _a;
        public double B => _b;
        public double C => _c;

        public Triangle(double a, double b, double c) 
        {
            _a = a;
            _b = b;
            _c = c;
            IsTriangleExist(a, b, c);
        }
        public double GetArea()
        {
            var halfP = (_a + _b + _c) / 2;
            var temp = halfP * (halfP - _a) * (halfP - _b) * (halfP - _c); 
            return Math.Sqrt(temp);
        }

        public bool IsRightTriangle()
        {
            var sides = new List<double>(3) { _a, _b, _c };
            var hypotenuse = sides.Max();
            sides.Remove(hypotenuse);
            return hypotenuse * hypotenuse == (sides[0] * sides[0] + sides[1] * sides[1]);
        }

        public static void IsTriangleExist(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Сторона треугольника не может быть меньше или равна нулю.");
            }
            var sides = new List<double>(3) { a, b, c };
            var m = sides.Max();
            sides.Remove(m);            
            if (m >= sides.Sum())
            {
                throw new ArgumentException("Треугольника с такими сторонами не существует.");
            }            
        }
    }
}
