using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchSubString
{
    public class Stack
    {
        private static int top = -1;
        private static string[] stack;
        public Stack(int size)
        {
            stack = new string[size];
        }
        public void Push(string element)
        {
            if (top < stack.Length - 1)
            {
                stack[++top] = element;
            }
            else
            {
                throw new Exception("Overflow");
            }
        }
        public string Pop()
        {
            string val;
            if (top == -1)
            {
                throw new Exception("Underflow");
            }
            else
            {
                val = stack[top];
                stack[top--] = "";

            }
            return val;
        }

    }
}
