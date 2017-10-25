using System;

namespace QueueLinkedListProject
{
    class QueueL
    {
        private Node front;
        private Node rear;

        public QueueL()
        {
            front = null;
            rear = null;
        }

        public int Size()
        {
            int s = 0;
            Node p = front;
            while(p != null)
            {
                s++;
                p = p.link;
            }
            return s;
        }

        public void Insert(int x)
        {
            Node temp;
            temp = new Node(x);

            if (front == null) /*If Queue is empty */
                front = temp;
            else
                rear.link = temp;
            rear = temp;
        }

        public int Delete()
        {
            int x;
            if (IsEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            x = front.info;
            front = front.link;
            return x;
        }
        
        private bool IsEmpty()
        {
            return (front == null);
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            return front.info;
        }

        public void Display()
        {
            Node p = front;
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }
            Console.Write("Queue is: ");
            while(p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }
    }
}