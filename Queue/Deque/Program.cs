using System;

namespace DequeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, x;

            Deque dq = new Deque(8);

            while(true)
            {
                System.Console.WriteLine("1. Insert at the front end.");
                System.Console.WriteLine("2. Insert at rear end.");
                System.Console.WriteLine("3. Delete from front end.");
                System.Console.WriteLine("4. Delete from rear end.");
                System.Console.WriteLine("5. Display all elements of deque.");
                System.Console.WriteLine("6. Quit");
                System.Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                    break;

                switch(choice)
                {
                    case 1:
                        System.Console.Write("Enter the element to be inserted: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        dq.InsertFront(x);
                        break;
                    case 2:
                        System.Console.Write("Enter the element to be inserted: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        dq.InsertRear(x);
                        break;
                    case 3:
                        System.Console.Write("Element deleted from the front end is: " + dq.DeleteFront());
                        break;
                    case 4:
                        System.Console.Write("Element deleted from the front end is: " + dq.DeleteRear());
                        break;
                    case 5:
                        dq.Display();
                        break;
                    default:
                        System.Console.Write("Please enter correct choice.");
                        break;
                }
            }
        }
    }
}
