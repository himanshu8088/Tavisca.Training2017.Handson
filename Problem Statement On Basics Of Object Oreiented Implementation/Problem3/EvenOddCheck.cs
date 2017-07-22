using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class EvenOddCheck
    {
        public bool isEven(int num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }

        public bool isOdd(int num)
        {
            if (num % 2 != 0)
                return true;
            else
                return false;
        }

    }
}
