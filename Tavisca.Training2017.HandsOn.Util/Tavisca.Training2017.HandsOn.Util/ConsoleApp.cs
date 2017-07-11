using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class ConsoleApp
    {

        static QueueUsingStack qs;
        static StackUsingQueue sq;
        static Stack stack;
        static Queue queue;
        static int choice;
        static int size;

        public void InputDataStructureChoice()
        {
            try
            {
                Console.WriteLine("Enter size of Data Structure:");
                size = Int32.Parse(Console.ReadLine());

                Console.WriteLine("\n\t\tChoose Program:\n\nPress(1) for Stack Program.\nPress(2) for Queue Program.\nPress(3) for QueueUsingStack Program.\nPress(4) for StackUsingQueue Program.");
                choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("\n\t\t\tWelcome to Stack Program:\n");
                    stack = new Stack(size);
                    RepeatInputOperationChoice();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\n\t\t\tWelcome to Queue Program:\n");
                    queue = new Queue(size);
                    RepeatInputOperationChoice();

                }
                else if (choice == 3)
                {
                    Console.WriteLine("\n\t\t\tWelcome to QueueUsingStack Program:\n");
                    qs = new QueueUsingStack(size);
                    RepeatInputOperationChoice();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("\n\t\t\tWelcome to StackUsingQueue Program:\n");
                    sq = new StackUsingQueue(size);
                    RepeatInputOperationChoice();
                }
                else
                {
                    throw new Exception("\nInvalid Input");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void RepeatInputOperationChoice()
        {
            while (IsMoreInput())
            {
                InputOperationChoice();
            }
            Environment.Exit(0);
        }

        public static Boolean IsMoreInput()
        {
            Console.WriteLine("\nWant to continue press(y) else press(n)\n");
            try
            {
                if (Console.ReadLine().ToLower().Equals("y"))
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public static void InputOperationChoice()
        {
            try
            {
                Console.WriteLine("\nFor insertion press(i).\nFor deletion press(d).\nFor Display press (o)\n");
                string jump = Console.ReadLine();
                Console.WriteLine("\n");

                //Insertion
                if (jump.Equals("i"))
                {
                    Console.WriteLine("Enter element:");
                    int element = Int32.Parse(Console.ReadLine());


                    if (choice == 1)
                        stack.Push(element);
                    else if (choice == 2)
                        queue.Enqueue(element);
                    else if (choice == 3)
                        qs.Enqueue(element);
                    else if (choice == 4)
                        sq.Push(element);
                    else
                        throw new Exception("Invalid Input");
                }
                //Deletion            
                else if (jump.Equals("d"))
                {
                    if (choice == 1)
                        stack.Pop();
                    else if (choice == 2)
                        queue.Dequeue();
                    else if (choice == 3)
                        qs.Dequeue();
                    else if (choice == 4)
                        sq.Pop();
                    else
                        throw new Exception("Invalid Input");
                }
                //Display
                else
                {
                    if (choice == 1)
                        Display(stack.Get());
                    else if (choice == 2)
                        Display(queue.Get());
                    else if (choice == 3)
                        Display(qs.Get());
                    else if (choice == 4)
                        Display(sq.Get());
                    else
                        throw new Exception("Invalid Input");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Display(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

    }
}
