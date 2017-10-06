using System;

namespace SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;

            LinkedList list = new LinkedList();

            while (true)
            {
                Console.WriteLine("1. Display list.");
                Console.WriteLine("2. Count the number of nodes.");
                Console.WriteLine("3. Search for an element.");
                Console.WriteLine("4. Insert in empty list / beginning of list.");
                Console.WriteLine("5. Insert the node at the end of the list.");
                Console.WriteLine("6. Insert a node after a specified node.");
                Console.WriteLine("7. Insert a node before a specified node.");
                Console.WriteLine("8. Insert a node at a given position.");
                Console.WriteLine("9. Delete first node.");
                Console.WriteLine("10. Delete last node.");
                Console.WriteLine("11. Delete any node.");
                Console.WriteLine("12. Reverse the list.");
                Console.WriteLine("13. Bubble sort by exchanging DATA.");
                Console.WriteLine("14. Bubble sort by exchanging LINKS.");
                Console.WriteLine("15. Merge Sort.");
                Console.WriteLine("16. Insert Cycle.");
                Console.WriteLine("17. Detect Cycle.");
                Console.WriteLine("18. Remove Cycle.");
                Console.WriteLine("19. Quit");

                Console.WriteLine("\nEnter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 19)
                    break;
                
                switch(choice)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine(value: "Exiting");
        }
    }
}