using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialSolution
{
    class Program
    {
        private static int num = 0;
        static void Main(string[] args)
        {

            Input();
            FactorialSol factSol = new FactorialSol(num);
            Console.WriteLine("Output after trimming trailing zeroes:"+factSol.GetTrimmedTrailZeroes());
            Console.ReadKey();
        }

        public static void Input()
        {
            Console.WriteLine("Input Value:");
            
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
