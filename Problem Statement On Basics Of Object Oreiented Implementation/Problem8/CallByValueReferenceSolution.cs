using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    public class CallByValueReferenceSolution
    {
        public CallByValueReferenceSolution()
        {
            int a = 10;
            int b = 50;
            AddByValue(a, b);
            AddByReference(ref a, ref b);
        }
        public void AddByValue(int a,int b)
        {
            Console.WriteLine("Added by call by value output:{0}",(a+b));
        }
        public void AddByReference(ref int a,ref int b)
        {
            Console.WriteLine("Added by call by refernce output:{0}", (a + b));
        }
    }
}
