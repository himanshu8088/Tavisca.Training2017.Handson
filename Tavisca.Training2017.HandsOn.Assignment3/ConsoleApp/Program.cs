using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1;
using Problem2;
using Problem3;
using Problem4;
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
                    StudentInformationSolution student = new StudentInformationSolution();
                    break;
                case 3:
                    EvenOddSolution numCheck = new EvenOddSolution();
                    break;
                case 4:
                    PowerOfNumberSolution power = new PowerOfNumberSolution();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
            
        }
    }
}
