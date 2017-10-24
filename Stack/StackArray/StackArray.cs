using System;

namespace StackArrayProject
{
    class StackA
    {
        private int[] stackArray;
        private int top;

        public StackA()
        {
            stackArray = new int[10];
            top = -1;
        }

        public StackA(int maxSize)
        {
            stackArray = new int[maxSize];
            top = -1;
        }

        public int Size()
        {
            return top + 1;
        }

        public bool isEmpty()
        {
            return (top == -1);
        }

        public bool isFull()
        {
            return (top == stackArray.Length-1);
        }

        public void Push(int x)
        {
            if (isFull())
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            top++;
            stackArray[top] = x;
        }

        public int pop()
        {
            int x;
            if (isEmpty())
                throw new System.InvalidOperationException("Stack Underflow");
            x = stackArray[top];
            top--;
            return x;
        }

        public int Peek()
        {
            if (isEmpty())
                throw new System.InvalidOperationException("Stack Underflow");
            return stackArray[top];
        }

        public void Display()
        {
            if (isEmpty())
            {
                System.Console.WriteLine("Stack is empty.");
                return;
            }
            System.Console.WriteLine("Stack is: ");
            for(int i = top; i >= 0; i--)
                System.Console.WriteLine(stackArray[i] + " ");
            System.Console.WriteLine();
        }
    }
}