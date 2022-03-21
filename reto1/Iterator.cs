using System;
namespace reto1
{
    internal interface Iterator<T>
    {
        bool hasNext();
        T next();
    }
}
