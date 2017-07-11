using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockSolution
{
    class ConsoleApp
    {
        public static double GetAngle()
        {
            try
            {
                Console.WriteLine("Input Angle:");
                return double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
