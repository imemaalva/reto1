using System;

namespace reto1
{
    internal class LinkedListIterator<T> : Iterator<T>
    {
        private Node<T> currentNode;

        internal LinkedListIterator(Node<T> startNode)
        {
            currentNode = startNode;
        }

        public bool hasNext()
        {
            return currentNode != null;
        }

        public T next()
        {
            T data = currentNode.data;

            currentNode = currentNode.next;

            return data;
        }
    }
}
