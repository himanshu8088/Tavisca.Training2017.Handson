using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class Stack
    {
        private static int top = -1;
        private static int[] stack;
        public Stack(int size)
        {
            stack = new int[size];
        }
        public void Push(int element)
        {
            if (top < stack.Length - 1)
                stack[++top] = element;
            else
                throw new Exception("Overflow");
            
        }
        public int Pop()
        {
            int val;
            if (top == -1)
                throw new Exception("Underflow");
            else
                val = stack[top];
                stack[top--] = 0;
            
            return val;
        }

        public int[] Get()
        {
            return stack;
        }

    }

}
