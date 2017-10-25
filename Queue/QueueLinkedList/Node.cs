using System;

namespace QueueLinkedListProject
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