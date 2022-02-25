using System;


namespace reto1
{
    public class Node
    {
        internal String data;
        internal Node next;
        internal Node previous;

        internal Node(String data)
        {
            this.data = data;
        }
    }
}
