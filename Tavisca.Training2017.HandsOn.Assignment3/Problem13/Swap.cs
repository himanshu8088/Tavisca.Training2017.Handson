using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13
{
    public class Swap
    {
        public static void DoSwap(ref int num1,ref int num2)
        {
            num1 = num1 ^ num2;
            num2 = num2 ^ num1;
            num1 = num1 ^ num2;
        }
    }
}
