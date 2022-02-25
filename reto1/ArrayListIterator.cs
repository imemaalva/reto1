using System;
namespace reto1
{
    public class ArrayListIterator
    {
        private reto1.ArrayList arrayList;
        private int currentItem;

        public ArrayListIterator(reto1.ArrayList arrayList)
        {
            this.arrayList = arrayList;
        }

        public bool hasNext()
        {
            return currentItem < arrayList.getSize();
        }

        public String next()
        {
            String data = arrayList.getAt(currentItem);

            currentItem++;

            return data;
        }
    }
}
