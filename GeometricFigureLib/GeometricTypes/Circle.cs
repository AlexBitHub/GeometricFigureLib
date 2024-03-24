using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureLib.GeometricTypes
{
    public class Circle : IFigure
    {
        private double _radius;
        public double Radius => _radius;

        public Circle(double radius) 
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус круга не может быть меньше или равен нулю.");
            }
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
