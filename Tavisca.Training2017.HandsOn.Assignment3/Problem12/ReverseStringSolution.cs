using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    public class ReverseStringSolution
    {
        int[] array1 = new int[] { 1, 2, 3, 4, 5 };
        string[] array2 = new string[] { "Hello","Bye"};
        public ReverseStringSolution()
        {            
            DisplayReversedArrayOnConsole<int>(Array<int>.Reverse(array1));
            DisplayReversedArrayOnConsole<string>(Array<string>.Reverse(array2));
        }
        public void DisplayReversedArrayOnConsole<T>(T[] array)
        {
            Console.WriteLine("\nReversed Array Element:");
            foreach(T element in array)
            {
                Console.Write(element+" ");
            }
        }
    }
}
