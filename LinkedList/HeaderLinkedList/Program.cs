using System;

namespace HeaderLinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, data, x, k;

            HeaderLinkedList list = new HeaderLinkedList();
            list.CreateList();

            Console.WriteLine("1. Display list.");
            Console.WriteLine("2. Insert the node at the end of the list.");
            Console.WriteLine("3. Insert a node before a specified node.");
            Console.WriteLine("4. Insert a node at a given position.");
            Console.WriteLine("5. Delete a node.");
            Console.WriteLine("6. Reverse the list.");
            Console.WriteLine("7. Quit");
            while(true)
            {
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 7)
                    break;
                
                switch(choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        Console.Write("Enter the element to be searched: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;
                    case 3:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element before which to insert: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data,x);
                        break;
                    case 4:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the position at which to insert: ");
                        k = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtPosition(data, k);
                        break;
                    case 5:
                        Console.Write("Enter the element to be deleted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;
                    case 6:
                        list.Reverse();
                        break;
                    default: 
                        Console.WriteLine("Please enter correct choice.");
                        break;
                }
            }

        }
    }
}
