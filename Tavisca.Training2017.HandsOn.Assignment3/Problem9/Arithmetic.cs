using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    public class Arithmetic
    {
        public static void Add(double num1,double num2,out double result) { result= num1 + num2; }
        public static void Subtract(double num1, double num2, out double result) { result = num1 - num2; }
        public static void Multiply(double num1, double num2, out double result) { result = num1 * num2; }
        public static void Divide(double num1, double num2, out double result) { result = num1 / num2; }
    }
}
