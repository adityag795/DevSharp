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
                System.Console.WriteLine("List is empty.");
                return;
            }

            Node p;
            System.Console.WriteLine("List is : ");
            p = start;
            while(p != null)
            {
                System.Console.WriteLine(p.info + " ");
                p = p.link;
            }
            System.Console.WriteLine();
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

            System.Console.WriteLine("Number of nodes : " + count);
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
                System.Console.WriteLine(x + " is not present in list.");
                return false;
            }
            else
            {
                System.Console.WriteLine(x + " is at position " + position);
                return true;
            }
        }

        
    }
}