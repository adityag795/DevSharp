using System;

namespace CircularLinkedListProject
{
    class CircularLinkedList
    {
        private Node last;

        public CircularLinkedList()
        {
            last = null;
        }

        public void DisplayList()
        {
            if (last == null)
            {
                Console.WriteLine("List is empty.\n");
                return;
            }

            Node p = last.link;
            do
            {
                Console.Write(p.info + " ");
                p = p.link;
            }while (p != last.link);
            Console.WriteLine();
        }

        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = last.link;
            last.link = temp;
        }

        
    }
}
