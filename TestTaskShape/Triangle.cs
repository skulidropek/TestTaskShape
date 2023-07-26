using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskShape
{
    public class Triangle : IShape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double a, double b, double c)
        {
            _sideA = a;
            _sideB = b;
            _sideC = c;
        }

        public double CalculateArea()
        {
            double s = (_sideA + _sideB + _sideC) / 2;
            double area = Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
            return area;
        }

        public bool IsRightAngledTriangle()
        {
            double aSquared = _sideA * _sideA;
            double bSquared = _sideB * _sideB;
            double cSquared = _sideC * _sideC;

            return Math.Abs(aSquared + bSquared - cSquared) < 0.0001 ||
                   Math.Abs(aSquared + cSquared - bSquared) < 0.0001 ||
                   Math.Abs(bSquared + cSquared - aSquared) < 0.0001;
        }
    }
}
