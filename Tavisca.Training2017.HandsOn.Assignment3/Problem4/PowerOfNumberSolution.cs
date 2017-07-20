using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    public class PowerOfNumberSolution
    {
        double num;
        int exponent;
        public PowerOfNumberSolution()
        {
            GetConsoleInput();
            PrintOnConsole();
        }
        public void GetConsoleInput()
        {
            Console.WriteLine("Enter Base:");
            double.TryParse(Console.ReadLine(),out num);
            Console.WriteLine("Enter Exponent:");
            int.TryParse(Console.ReadLine(), out exponent);
        }
        public void PrintOnConsole()
        {
            Console.WriteLine("Output: {0}",Compute());
        }
        public double Compute()
        {
            return PowerOfNumber<double, int>.Calculate(num,exponent);
        }
    }
}
