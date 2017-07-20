using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1;
using Problem2;
using Problem3;
using Problem4;
using Problem5;
using Problem6;
using Problem7;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Problem No.");
            int choice;
            int.TryParse(Console.ReadLine(),out choice);
            switch (choice)
            {
                case 1:
                    MailingAddressSolution mailingAddress = new MailingAddressSolution();
                    break;
                case 2:
                    StudentInformationSolution studentInfo = new StudentInformationSolution();
                    break;
                case 3:
                    EvenOddSolution numEvenOdd = new EvenOddSolution();
                    break;
                case 4:
                    PowerOfNumberSolution powerOfNumber = new PowerOfNumberSolution();
                    break;
                case 5:
                    TaxSolution taxAmount = new TaxSolution();
                    break;
                case 6:
                    MathSolution math = new MathSolution();
                    break;
                case 7:
                    Ladder ladder = new Ladder(5);
                    break;
                default:
                    break;
            }
            Console.ReadKey();
            
        }
    }
}
