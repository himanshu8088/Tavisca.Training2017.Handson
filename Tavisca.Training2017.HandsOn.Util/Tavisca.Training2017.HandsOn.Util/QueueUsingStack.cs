using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Util
{
    public class QueueUsingStack
    {
        Stack stack1, stack2;
                
        public QueueUsingStack(int size)
        {                        
             stack1 = new Stack(size);
             stack2 = new Stack(size);            
        }
                
        public void Enqueue(int element)
        {
            stack1.Push(element);
            stack2.Push(stack1.Pop());

        }
        public int Dequeue()
        {
           return stack2.Pop();            
        }

        public int[] Get()
        {
            return stack2.Get();
        }

    }
}
