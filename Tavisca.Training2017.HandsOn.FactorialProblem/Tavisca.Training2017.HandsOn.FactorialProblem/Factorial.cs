using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialSolution
{
    class FactorialSol
    {
        //private static int size=1;
        //private static int carry=0;
        //private static int[] digitHolder;
        //private int num;
        
        private long trimmedVal;

        public FactorialSol(int num)
        {            
            trimmedVal=RemoveTrailingZeros(Factorial(num));
        }    

        public long Factorial(int num)
        {
            if (num == 1 || num == 0)
                return 1;
            else
            {                
                return num*Factorial(num-1);
            }
               
        }

        public void XBaseToDecimalConversion()
        {

        }

        public void DecimalToXBaseConversion()
        {

        }

        public long RemoveTrailingZeros(long num)
        {
            return long.Parse(num.ToString().TrimEnd('0'));
        }

        public long GetTrimmedTrailZeroes()
        {

            return trimmedVal;
        }


/*
        public int Eval()
        {
            size = num.ToString().Length;
            int i = 0;
            digitHolder = new int[size];
            int num1=num;
            while (i<size)
            {
                int temp = num1 / 10;
                digitHolder[i] = temp;
                num1 = num1 % 10;                
                i++;
            }
            if (i == size)
                digitHolder[size - 1] = num % 10;           

            return int.Parse(ConcatResult(MultiplicationResult(num - 1)));
        }
        private int[] MultiplicationResult(int x)
        {
            int i=size-1;
            size++;
            int[] tempDigitHolder = new int[size];
            int j = 0;
            while (i>-1)
            {
                int product = digitHolder[i] * x + carry;
                tempDigitHolder[j] = product % 10;                
                carry = product / 10;                
                i--;
                j++;
            }
            
            tempDigitHolder[j] = carry;
            digitHolder = new int[size];
            Display( ReverseArray(tempDigitHolder));


            return ReverseArray(tempDigitHolder);
        } 
        
        private int[] ReverseArray(int[] temp)
        {
            int index=0;
           
            while (index<temp.Length)
            {
                digitHolder[index] = temp[temp.Length-index-1];                
                index++;
            }
            return digitHolder;
        }

        private string ConcatResult(int[] res)
        {
            string result="";
            foreach (int index in res)
                result += index;
            return result;
        }

        public void Display(int[] arr)
        {
            int i = 0;
            Console.WriteLine("arr:");
            while (i<arr.Length)
            {
                Console.Write(arr[i]+" ");
                i++;
            }
            Console.WriteLine();
        }

    */
    }
}
