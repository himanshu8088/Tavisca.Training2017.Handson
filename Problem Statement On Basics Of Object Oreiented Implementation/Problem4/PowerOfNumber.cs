using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class PowerOfNumber<T,U>
    {
        public static bool isValidInputType()
        {
            if (typeof(T) != typeof(double) && typeof(T) != typeof(int) && typeof(T) != typeof(long) && typeof(T) != typeof(float) && typeof(U) != typeof(double) && typeof(U) != typeof(int) && typeof(U) != typeof(long) && typeof(U) != typeof(float))
                throw new Exception("Invalid Type Specified");
            return true;
        }
        public static double Calculate(T num, U toPower)
        {
            if (isValidInputType())
            {
                double number = Convert.ToDouble(num);
                double toPow = Convert.ToDouble(toPower);
                return Math.Pow(number, toPow);
            }
            return -1;
        }
    }
}
