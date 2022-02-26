using System;
using System.Collections.Generic;
using System.Text;

namespace BasicArrayList
{
    public class ArrayList
    {
        private const int Initial_Capacity = 2;
        private int[] items;
        public ArrayList()
        {
            this.items = new int[Initial_Capacity];
        }
        public int Count { get; private set; }

        public void Add(int item)
        {
            if (this.Count == this.items.Length)
            {
                int[] copy = new int[this.items.Length * 2];
                for (int i = 0; i < this.items.Length; i++)
                {
                    copy[i] = this.items[i];
                }
                this.items = copy;
            }
            this.items[this.Count] = item;
            this.Count++;
        }

        public int CountFreePositions()
        {
            int freeSpace; 
            freeSpace = items.Length - Count;
            return freeSpace;
           
        }

        public void Cut(int count)
        {
            if (count > Count)
            {
                throw new ArgumentOutOfRangeException("Number is out of range.");
            }
            int[] newArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = this.items[i];
                Count--;
            }
            items = newArray;
        }
       public int Change(int element, int newElement)
        {
            for (int i = 0; i < items.Length; i++)
            {
                int current = items[i];

                if (current == element)
                {
                    items[i] = newElement;
                    return i;
                }
            }
            return -1;
        }
    }
}
