using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    public class CopyArraySolution
    {
        string[] arrFrom;
        string[] arrTo;        
        public CopyArraySolution()
        {
            GetArrayFromConsole();
            Array<string>.Copy(ref arrFrom, ref arrTo);
            Display();
        }
        public void Display()
        {
            Console.WriteLine("Copied array:");
            foreach (string a in arrTo)
            {
                Console.Write(a+" ");                
            }
        }
        public void GetArrayFromConsole()
        {
            Console.WriteLine("Enter arr element separated by<,>:");
            arrFrom = Console.ReadLine().Split(',');
        }
        

    }
}
