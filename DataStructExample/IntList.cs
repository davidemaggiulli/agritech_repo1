using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructExample
{
    internal class IntList : IIntList
    {
        private int[] items;
        private int pos;

        public IntList()
        {
            items = new int[4];
            pos = 0;
        }

        public void Add(int item)
        {
            if(pos >= items.Length)
            {
                ExpandArray();
            }
            items[pos] = item;
            pos = pos + 1;
        }

        public int Count()
        {
            return pos;
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == item)
                    return i;
            }
            //Elemento non trovato
            return -1;
        }

        public int ItemAt(int index)
        {
            if(index >= 0 && index < pos)
                return items[index];
            throw new IndexOutOfRangeException();
        }

        public void RemoveAt(int index)
        {
            if(index < 0 || index >= pos)
                throw new IndexOutOfRangeException();
            int[] newArray = new int[items.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = items[i];
            }
                
            for(int i = index + 1; i < items.Length; i++)
            {
                newArray[i - 1] = items[i];
            }
                
            items = newArray;
        }

        private void ExpandArray()
        {
            int[] newArray = new int[items.Length + 4];
            for(int i = 0; i < items.Length; i++)
            {
                newArray[i] = items[i];
            }
            items = newArray;
        }
    }
}
