using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class EvenOddNumber
    {
        EvenOddCheck numCheck;
        private int num;
        public EvenOddNumber()
        {
            numCheck = new EvenOddCheck();
            GetNumberFromConsole();
            DisplayStatusOnConsole();
        }

        private void GetNumberFromConsole()
        {
            Console.WriteLine("Enter Number To Check:");            
            int.TryParse(Console.ReadLine(),out num);
        }

        private void DisplayStatusOnConsole()
        {
            if (numCheck.isEven(num))
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        } 
    }
}
