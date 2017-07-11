using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchSubString
{
    
    class ConsoleApp
    {
        private static string str, substr;
        public static void Input()
        {
            Console.WriteLine("Enter string: ");
            str = Console.ReadLine();

            Console.WriteLine("Enter substring: ");
            substr = Console.ReadLine();
        }
        public static void Output()
        {
            Search search = new Search(str, substr);
            if (search.FindMatch())
                Console.WriteLine("Found");
            else
                Console.WriteLine("Not Found");
        }
    }
}
