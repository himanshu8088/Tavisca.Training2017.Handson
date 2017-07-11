using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortByStack
{
    public class ConsoleApp
    {
        private static int size;
        private static int[] arr;

        public static void Input()
        {
            Console.WriteLine("Enter arr size: ");
            try
            {
                size = Int32.Parse(Console.ReadLine());
                arr = new int[size];
                Console.WriteLine("Input element: ");
                for (int i = 0; i < size; i++)
                {
                    arr[i] = Int32.Parse(Console.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static void Display(int[] arr1)
        {
            Console.WriteLine("\nSorted Array\n");
            foreach (int i in arr1)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] GetArray()
        {
            return arr;
        }
    }
}
