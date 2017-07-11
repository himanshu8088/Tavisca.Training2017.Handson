using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Util
{
    public class StackUsingQueue
    {
        Queue queue1, queue2;
        int size;
        public StackUsingQueue(int size)
        {
            this.size = size;
            queue1 = new Queue(size);
            queue2 = new Queue(size);
        }
        public void Push(int element)
        {            
            queue1.Enqueue(element);            
        }
        public int Pop()
        {
            int val=0;
            int i = queue1.GetNoOfElement();            
            if (i < 1)
                throw new Exception("Underflow");            
            while (i > 1)
            {
                queue2.Enqueue(queue1.Dequeue());
                i--;
            }
            val = queue1.Dequeue();            
            queue1 = queue2;
            queue2 = new Queue(size);             
            return val;            
        }
        public int[] Get()
        {            
              return queue1.Get();            
        }
    }
}
