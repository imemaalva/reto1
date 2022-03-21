﻿namespace reto1
{
    internal interface List<T>
    {
        void addAtTail(T data);
        void addAtFront(T data);
        void removeAll();
        void remove(int index);
        void setAt(int index, T data);
        T getAt(int index);
        Iterator<T> getIterator();
        int getSize();
    }
}
