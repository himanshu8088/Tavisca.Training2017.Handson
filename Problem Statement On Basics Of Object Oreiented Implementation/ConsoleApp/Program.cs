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
using Problem8;
using Problem9;
using Problem10;
using Problem11;
using Problem12;
using Problem13;
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
                    LadderSolution ladder = new LadderSolution(5);
                    break;
                case 8:
                    CallByValueReferenceSolution call = new CallByValueReferenceSolution();
                    break;
                case 9:
                    OutParameterSolution outParam = new OutParameterSolution();
                    break;               
                case 11:
                    CopyArraySolution copy = new CopyArraySolution();
                    break;
                case 12:
                    ReverseStringSolution reverseString = new ReverseStringSolution();
                    break;
                case 13:
                    SwapSolution swap = new SwapSolution();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
            
        }
    }
}
