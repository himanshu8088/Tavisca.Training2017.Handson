using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13
{
    public class SwapSolution
    {
        public SwapSolution()
        {
            int num1 = 10,num2 = 5;
            Console.WriteLine("Before Swapping number 1={0} and number 2={1}",num1,num2);
            Swap.DoSwap(ref num1,ref num2);
            Console.WriteLine("After Swapping number 1={0} and number 2={1}", num1, num2);
        }
    }
}
