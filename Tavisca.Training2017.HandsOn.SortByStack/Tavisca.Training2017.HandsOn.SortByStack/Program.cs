using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortByStack
{
    class Program
    {        
        static void Main(string[] args)
        {
            ConsoleApp.Input();            
            Sort sort = new Sort(ConsoleApp.GetArray());            
            ConsoleApp.Display(sort.SortedArray());
            Console.ReadKey();
        }        
    }
}
