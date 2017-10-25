using System;

namespace CircularQueueProject
{
    class Node
    {
        public int info;
        public Node link;

        public Node(int i)
        {
            info = i;
            link = null;
        }
    }
}