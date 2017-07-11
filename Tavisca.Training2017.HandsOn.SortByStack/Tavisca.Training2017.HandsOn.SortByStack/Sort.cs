using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortByStack
{
    public class Sort
    {
        private static int[] array;
        private static Stack stack;
        public Sort(int[] arr)
        {
            array = arr;            
                      
        }
        public int[] SortedArray()
        {
            stack = new Stack(2);
            for(int i=0; i < array.Length; i++)
            {
                
                for(int j = 0; j < array.Length - i - 1; j++)
                {                    
                    if (array[j]<array[j+1])
                    {
                        stack.Push(array[j]);
                        array[j] = array[j + 1];
                        array[j + 1] = stack.Pop();
                    }
                }
            }
            return array;
        }

    }
}
