using System;

namespace StackLinkedListProject
{
    class StackL
    {
        private Node top;

        public StackL()
        {
            top = null;
        }

        public int Size()
        {
            int s = 0;
            Node p = top;
            while(p != null)
            {
                p = p.link;
                s++;
            }
            return s;
        }

        public void Push(int x)
        {
            Node temp = new Node(x);
            temp.link = top;
            top = temp;
        }

        public int Pop()
        {
            int x;
            if (IsEmpty())
                throw new System.InvalidOperationException("Stack Underflow");
            x = top.info;
            top = top.link;
            return x;
        }

        private bool IsEmpty()
        {
            return (top == null);
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new System.InvalidOperationException("Stack Underflow");
            return top.info;
        }

        public void Display()
        {
            Node p = top;

            if (IsEmpty())
            {
                System.Console.WriteLine("Stack is empty.");
                return;
            }

            System.Console.WriteLine("Stack is: ");
            while(p != null)
            {
                System.Console.WriteLine(p.info + " ");
                p = p.link;
            }
            System.Console.WriteLine();
        }
    }
}