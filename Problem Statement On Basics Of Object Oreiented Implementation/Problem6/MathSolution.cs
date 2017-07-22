using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
   public class MathSolution
    {        
        Object addition;
        double theta;
        public MathSolution()
        {
            if (OptChoice() == 1)
            {                
                GetArithmeticOperationInputFromConsole();
                DisplayArithmeticOperationOutputOnConsole();
            }
            else
            {
                GetTrigonometricOperationInputFromConsole();
                DisplayTrigonometricOperationOutputOnConsole();
            }
                
        }
        public int OptChoice()
        {
            Console.WriteLine("Choose Operation\nPress<1> for Arithmetic Addition\nPress<2> for Trigonometric Sin(theta) Operation");
            char ch=Console.ReadKey().KeyChar;
            if (ch.Equals('1'))
                return 1;
            else if (ch.Equals('2'))
                return 2;
            else
                throw new Exception("Invalid key pressed");
        }
        public void GetArithmeticOperationInputFromConsole()
        {
            Console.WriteLine("\nEnter number separated by <,> for addition");
            Object[] input = Console.ReadLine().Split(',');
            addition=ArithmeticMath.Add(input);
        }
        public void DisplayArithmeticOperationOutputOnConsole()
        {
            Console.WriteLine("Output:{0}",addition);
        }

        public void GetTrigonometricOperationInputFromConsole()
        {            
            Console.WriteLine("\nEnter theta for calculating sin(theta):");            
            double.TryParse(Console.ReadLine(),out theta);
            theta=TrigonometricMath.Sin(theta);
            
        }
        public void DisplayTrigonometricOperationOutputOnConsole()
        {
            Console.WriteLine("Output:{0}",theta);
        }
        
    }
}
