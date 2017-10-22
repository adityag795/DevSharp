using System;

namespace DoubleLinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, data, x;

            DoubleLinkedList list = new DoubleLinkedList();
            list.CreateList();

            while (true)
            {
                Console.WriteLine("1. Display List");
                Console.WriteLine("2. Insert in empty list");
                Console.WriteLine("3. Insert a node in the beginning of the list.");
                Console.WriteLine("4. Insert a node at the end of the list.");
                Console.WriteLine("5. Insert a node after a specified node.");
                Console.WriteLine("6. Insert a node before a specified node.");
                Console.WriteLine("7. Delete first node.");
                Console.WriteLine("8. Delete last node.");
                Console.WriteLine("9. Delete any node.");
                Console.WriteLine("10. Reverse the list.");
                Console.WriteLine("11. Quit.");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 11)
                    break;
            }

            switch (choice)
            {
                case 1: 
                    list.DisplayList();
                    break;
                case 2:
                    Console.Write("Enter the element to be inserted: ");
                    data = Convert.ToInt32(Console.ReadLine());
                    list.InsertInEmptyList(data);
                    break;
                default:
                    System.Console.WriteLine("Please enter correct choice");
                    break;
            }
        }
    }
}