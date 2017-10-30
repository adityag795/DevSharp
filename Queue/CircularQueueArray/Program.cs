using System;

namespace CircularQueueArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, x;

            CircularQueue qu = new CircularQueue(8);

            Console.WriteLine("1. Insert an element on the queue.");
            Console.WriteLine("2. Delete an element from the queue.");
            Console.WriteLine("3. Display the element at the front.");
            Console.WriteLine("4. Display all the queue elements.");
            Console.WriteLine("5. Display the size of queue.");
            Console.WriteLine("6. Quit.");

            while(true)
            {
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                    break;
                
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter the element to be pushed: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        qu.Insert(x);
                        break; 
                    case 2:
                        x = qu.Delete();
                        Console.WriteLine("Element deleted is " + x);
                        break;
                    case 3:
                        Console.WriteLine("Element at the front is " + qu.Peek());
                        break;
                    case 4:
                        qu.Display();
                        break;
                    case 5:
                        Console.WriteLine("Size of queue is " + qu.Size());
                        break;
                    default:
                        Console.WriteLine("Please enter correct choice");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
