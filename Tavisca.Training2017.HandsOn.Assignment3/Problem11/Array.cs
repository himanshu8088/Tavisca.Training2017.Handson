using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    public class Array<T>
    {
        public static void Copy(ref T[] arrFrom,ref T[] arrTo)
        {
            arrTo = arrFrom;            
        }
    }
}
