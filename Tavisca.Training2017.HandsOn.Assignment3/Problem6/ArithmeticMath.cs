using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    public class ArithmeticMath
    {
        public static double Add(params Object[] numbers)
        {
            double sum=0;
            foreach (Object num in numbers)
            {
                double number = double.Parse(num.ToString());
                sum += number;
            }
            return sum;
        }
    }
}
