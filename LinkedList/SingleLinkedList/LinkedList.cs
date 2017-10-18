using System;

namespace SingleLinkedList
{
    class LinkedList
    {
        private Node start;
        public LinkedList()
        {
            start = null;
        }

        public void DisplayList()
        {
            // Zero element check
            if (start == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Node p;
            Console.WriteLine("List is : ");
            p = start;
            while(p != null)
            {
                Console.WriteLine(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }

        public void CountNodes()
        {
            int count = 0;
            Node p = start;
            while(p != null)
            {
                count++;
                p = p.link;
            }

            Console.WriteLine("Number of nodes : " + count);
        }

        public bool Search(int x)
        {
            int position = 1;
            Node p = start;
            while(p != null)
            {
                if (p.info == x)
                    break;
                position++;
                p = p.link;
            }
            if (p == null)
            {
                Console.WriteLine(x + " is not present in list.");
                return false;
            }
            else
            {
                Console.WriteLine(x + " is at position " + position);
                return true;
            }
        }

        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;
        }

        public void InsertAtEnd(int data)
        {
            Node p = start;
            Node temp = new Node(data);

            // If Linked List is empty
            if (start == null)
            {
                start = temp;
                return;
            }
            
            while(p.link != null)
                p = p.link;

            p.link = temp;
        }

        public void InsertAfter(int data, int x)
        {
            Node p = start;

            while(p != null)
            {
                if (p.info == x)
                    break;
                p = p.link;
            }

            if (p == null)
                System.Console.WriteLine(x + " is not present in the list.");
            else
            {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void InsertBefore(int data, int x)
        {
            Node temp;

            if (start == null)
            {    
                Console.WriteLine("List is empty.");
                return;
            }

            if (x == start.info)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;

            while(p != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }

            if (p == null)
                System.Console.WriteLine(x + " is not present in the list.");
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void InsertAtPosition(int data, int k)
        {
            Node temp;
            int i;

            // If insertion is at first position
            if (k == 1)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            // Finding reference to the kth node
            Node p =start;
            for(i = 1; i <= k && p.link != null; i++)
                p = p.link;
            
            if (p == null)
                Console.WriteLine("You can only insert upto " + i + "th position.");
            else
                {
                    temp = new Node(data);
                    temp.link = p.link;
                    p.link = temp;
                }
        }

        public void CreateList()
        {
            int i, n, data;

            Console.Write("Enter the number of nodes: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;

            for(i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter the element to be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }

        public void DeleteFirstNode()
        {
            if (start == null)
                return;
            start = start.link;
        }

        public void DeleteLastNode()
        {
            if (start == null)
                return;

            if (start.link == null)
            {    
                start = null;
                return;
            }    

            Node p = start;
            while(p.link.link != null)
                p = p.link;
            p.link = null;
        }

        public void DeleteNode(int x)
        {
            if (start == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            // Deletion of First Node
            if (start.info == x)
            {
                start = start.link;
                return;
            }
            // Deletion in between or at the end
            Node p = start;
            while(p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }

            if (p.link == null)
                Console.WriteLine("Element " + x + " not in the list.");
            else
                p.link = p.link.link;
        }

        public void ReverseList()
        {
            Node prev, p, next;
            prev = null;
            p = start;
            while(p != null)
            {
                next = p.link;
                p.link = prev;
                prev = p;
                p = next;
            }
            start = prev;
        }

    }
}