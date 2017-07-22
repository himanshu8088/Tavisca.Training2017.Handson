using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class Rectangle
    {
        public static double Area(double length,double breadth)
        {
            return length * breadth;
        }
        public static double Perimeter(double length, double breadth)
        {
            return 2*(length + breadth);
        }
    }
}
