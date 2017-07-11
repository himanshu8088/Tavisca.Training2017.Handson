using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class Queue
    {
        private  int[] queue;
        private  int rear = -1, front = -1;
        private  int queue_size;
        private int no_of_element=0;
        public Queue(int q_size)
        {
            queue_size = q_size;
            queue = new int[q_size];
        }

        public int GetNoOfElement()
        {
            return no_of_element;
        }

        public void Enqueue(int value)
        {
            if ((front == 0 && rear == queue_size - 1) || (front == rear + 1))
                throw new Exception("Queue is Full");
            else
            {
                if (rear == queue_size - 1 && front != 0)
                    rear = -1;
                queue[++rear] = value;
                no_of_element++;
                if (front == -1)
                    front = 0;
            }
        }
        public int Dequeue()
        {
            int val=0;
            if (front == -1 && rear == -1)
               throw new Exception("Queue is Empty");
            else
            {
                no_of_element--;
                val = queue[front++];
                if (front == queue_size)
                    front = 0;
                if (front - 1 == rear)
                    front = rear = -1;
            }
            return val;
        }
        public int[] Get()
        {
            int[] q = new int[queue_size];
            int j = 0;
            if (front == -1)
                throw new Exception("Queue is Empty");
            else
            {
                int i = front;

                if (front <= rear)
                {
                    while (i <= rear)
                    {
                        q[j] = queue[i++];
                        j++;
                    }
                }
                else
                {
                    while (i <= queue_size - 1)
                    {
                        q[j] = queue[i++];
                        j++;
                    }
                    i = 0;
                    while (i <= rear)
                    {
                        q[j] = queue[i++];
                        j++;
                    }
                }
            }
            return q;
        }
    }
}
