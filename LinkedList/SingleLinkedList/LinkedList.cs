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

        
    }
}