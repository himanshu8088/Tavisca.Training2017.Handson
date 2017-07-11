using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockSolution
{
    class Program
    {
        
        static void Main(string[] args)
        {            
            Clock clock = new Clock(ConsoleApp.GetAngle());            
            Console.WriteLine("Time list lie between this angle:\n" + clock.GetListOfTimeMatched());            
            Console.ReadKey();
        }
        
    }
}
