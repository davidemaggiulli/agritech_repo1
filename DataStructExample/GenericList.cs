using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructExample
{
    public class GenericList<T> : IGenericList<T>
    {
        private T[] items;
        private int pos;

        public GenericList()
        {
            items = new T[4];
            pos = 0;
        }
        public void Add(T item)
        {
            if (pos >= items.Length)
            {
                ExpandArray();
            }
            items[pos++] = item;
        }

        public int Count()
        {
            return pos;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(item))
                    return i;
            }
            //Elemento non trovato
            return -1;
        }

        public T ItemAt(int index)
        {
            if (index >= 0 && index < pos)
                return items[index];
            throw new IndexOutOfRangeException();
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= pos)
                throw new IndexOutOfRangeException();
            T[] newArray = new T[items.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = items[i];
            }

            for (int i = index + 1; i < items.Length; i++)
            {
                newArray[i - 1] = items[i];
            }

            items = newArray;
            pos--;
        }

        private void ExpandArray()
        {
            T[] newArray = new T[items.Length + 1];
            for (int i = 0; i < items.Length; i++)
            {
                newArray[i] = items[i];
            }
            items = newArray;
        }

        public void Clear()
        {
            items = new T[4];
            pos = 0;
        }
    }
}
