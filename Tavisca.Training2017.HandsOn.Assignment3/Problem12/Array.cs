using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    class Array<T>
    {
        public static T[] Reverse(T[] array)
        {
            T[] reverse = new T[array.Length];
            for(int i = 0,j=array.Length-1; i <array.Length; i++,j--)
            {
                reverse[i] = array[j];
            }
            return array;
        }
    }
}
