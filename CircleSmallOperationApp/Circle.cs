using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleSmallOperationApp
{
    class Circle
    {
        public double radius;

        public double GetDiameter(double radius)
        {
            double diameter = radius * 2;
            return diameter;

        }

        public double GetPerimeter(double radius)
        {
            double perimeter = 2 * Math.PI * radius;
            return perimeter;

        }

        public double GetArea(double radius)
        {
            double area = Math.PI * (radius * radius);
            return area;
        }
    }
}
