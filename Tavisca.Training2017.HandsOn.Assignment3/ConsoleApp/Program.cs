using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1;
using Problem2;
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
                    MailingAddress mailingAddress = new MailingAddress();
                    break;
                case 2:
                    Student student = new Student();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
            
        }
    }
}
