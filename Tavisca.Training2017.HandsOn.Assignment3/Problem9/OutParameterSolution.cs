using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    public class OutParameterSolution
    {
        double result;
        public OutParameterSolution()
        {
            PerformArthmeticOperation();
            Display();
        }
        public int OptChoice()
        {
            Console.WriteLine("Choose Operation\nPress<1> for Addition\nPress<2> for Subtraction\nPress<3> for Multiplication\nPress<4> for Division");
            char ch = Console.ReadKey().KeyChar;
            if (ch.Equals('1'))
                return 1;
            else if (ch.Equals('2'))
                return 2;
            else if (ch.Equals('3'))
                return 3;
            else if (ch.Equals('4'))
                return 4;
            else
                throw new Exception("Invalid key pressed");
        }
        public void PerformArthmeticOperation()
        {
            int choice = OptChoice();
            double num1, num2;
            Console.WriteLine("\nEnter 2 number:");
            double.TryParse(Console.ReadLine(), out num1);
            double.TryParse(Console.ReadLine(), out num2);
            switch (choice)
            {
                case 1:
                    Arithmetic.Add(num1, num2, out result);
                    break;
                case 2:
                    Arithmetic.Subtract(num1, num2, out result);
                    break;
                case 3:
                    Arithmetic.Multiply(num1, num2, out result);
                    break;
                case 4:
                    Arithmetic.Divide(num1, num2, out result);
                    break;
            }
        }
        public void Display()
        {
            Console.WriteLine("Output:{0}",result);
        }
    }


}
