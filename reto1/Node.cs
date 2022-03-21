using System;


namespace reto1
{
    internal class Node <T>
    {
        internal T data;
        internal Node<T> next;
        internal Node<T> previous;

        internal Node(T data)
        {
            this.data = data;
        }
    }
}
