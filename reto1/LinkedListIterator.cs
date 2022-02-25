using System;

namespace reto1
{
    public class LinkedListIterator
    {
        private Node currentNode;

        public LinkedListIterator(Node startNode)
        {
            currentNode = startNode;
        }

        public bool hasNext()
        {
            return currentNode != null;
        }

        public String next()
        {
            String data = currentNode.data;

            currentNode = currentNode.next;

            return data;
        }
    }
}
