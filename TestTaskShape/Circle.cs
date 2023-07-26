using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskShape
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
