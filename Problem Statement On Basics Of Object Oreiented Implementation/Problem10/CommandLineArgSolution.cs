using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    public class CommandLineArgSolution
    {
        static void Main(string[] args)
        {
            double length, breadth;
            double.TryParse(args[0], out length);
            double.TryParse(args[1], out breadth);
            Console.WriteLine("area:{0}", Rectangle.Area(length, breadth));
            Console.WriteLine("perimeter:{0}", Rectangle.Perimeter(length, breadth));
        }

    }
}
