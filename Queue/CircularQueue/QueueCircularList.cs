using System;

namespace CircularQueueProject
{
    class CircularQueue
    {
        private Node rear;

        public CircularQueue()
        {
            rear = null;
        }

        public bool IsEmpty()
        {
            return (rear == null);
        }

        public void Insert(int x)
        {
            Node temp = new Node(x);

            if (IsEmpty()) /*Insertion in Empty List */
            {
                rear = temp;
                rear.link = rear;
            }
            else
            {
                temp.link = rear.link;
                rear.link = temp;
                rear = temp;
            }
        }

        public int Delete()
        {
            if (IsEmpty())
                throw new System.InvalidOperationException("Queue Underflow.");
            
            Node temp;
            if (rear.link == rear) /*If only one element */
            {
                temp = rear;
                rear = null;
            }
            else
            {
                temp = rear.link;
                rear.link = temp.link;
            }
            return temp.info;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new System.InvalidOperationException("Queue Underflow.");
            return rear.link.info;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }
            
            Console.Write("Queue is: ");
            Node p = rear.link;
            do
            {
                Console.Write(p.info + " ");
                p = p.link;
            }while(p != rear.link);
            Console.WriteLine();
        }

        public int Size()
        {
            if (IsEmpty())
                return 0;
            
            int s = 0;
            Node p = rear.link;
            do{
                s++;
                p = p.link;
            }while(p != rear.link);
            return s;
        }
    }
}