using System;

namespace CircularQueueArray
{
    class CircularQueue
    {
        private int[] queueArray;
        private int front;
        private int rear;

        public CircularQueue()
        {
            queueArray = new int[10];
            front = -1;
            rear = -1;
        }

        public CircularQueue(int maxSize)
        {
            queueArray = new int[maxSize];
            front = -1;
            rear = -1;
        }

        public bool IsEmpty()
        {
            return (front == -1);
        }

        public bool IsFull()
        {
            return ((front == 0 && rear == queueArray.Length-1) || (front == rear+1));
        }
        
        public void Insert(int x)
        {
            if (IsFull())
            {
                System.Console.WriteLine("Queue overflow.\n");
                return;
            }
            
            if (front == -1)
                front = 0;
            
            if (rear == queueArray.Length-1)
                rear = 0;
            else
                rear++;

            queueArray[rear] = x;
        }

        public int Delete()
        {
            if (IsEmpty())
                throw new System.InvalidOperationException("Queue Underflow");

            int x = queueArray[front];

            if (front == rear) /*queue has only one element */
            {
                front = -1;
                rear = -1;
            }
            else if(front == queueArray.Length-1)
                front = 0;
            else
                front++;
            
            return x;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new System.InvalidOperationException("Queue Underflow");

            return queueArray[front];
        }

        public void Display()
        {
            if (IsEmpty())
            {
                System.Console.WriteLine("Queue is empty.");
                return;
            }

            System.Console.Write("Queue is: ");

            int i = front;
            if (front <= rear)
            {
                while(i <= rear)
                    System.Console.Write(queueArray[i++] + " ");
            }
            else
            {
                while(i <= queueArray.Length-1)
                    System.Console.Write(queueArray[i++] + " ");
                i = 0;
                while(i <= rear)
                    System.Console.Write(queueArray[i++] + " ");
            }
            System.Console.WriteLine();
        }

        public int Size()
        {
            if (IsEmpty())
                return 0;
            if (IsFull())
                return queueArray.Length;

            int i = front;
            int sz = 0;
            if (front <= rear)
                while(i <= rear)
                {
                    sz++;
                    i++;
                }
            else
            {
                while(i <= queueArray.Length-1)                
                {
                    sz++;
                    i++;
                }
                i = 0;
                while(i <= rear)
                {
                    sz++;
                    i++;
                }
            }
            return sz;
        }
    }
}