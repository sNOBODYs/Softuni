namespace ImplementArrayList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CustomArrayList
    {
        private object[] arrayObject;

        private int count;

        public int Count
        {   
            get => count;
            set
            {
                count = value;
            }
        }

        private static readonly int INITIAL_CAPACITY = 4;

        public CustomArrayList()
        {
            arrayObject = new object[INITIAL_CAPACITY];
            count = 0;
        }

        public void Add(object item)
        {
            Insert(count, item);
        }

        public object Remove(int index) 
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }

            object item = arrayObject[index];

            arrayObject[index] = null;

            for (int i = index; i < arrayObject.Length - 1; i++)
            {
                arrayObject[i] = arrayObject[i + 1];
            }

            arrayObject[count - 1] = null;
            count--;

            if (count <= arrayObject.Length / 2)
            {
                Shrink();
            }

            return item;
        }

        private void Shrink()
        {
            object[] copy = new object[arrayObject.Length / 2];

            Array.Copy(arrayObject, copy, copy.Length);

            arrayObject = copy;
        }

        public int Remove(object item)
        {
            int index = IndexOf(item);

            if (index == -1)
            {
                return index;
            }
            Remove(index);

            return index;
        }

        public bool Contains(object item)
        {
            int currentIndex = IndexOf(item);

            if (currentIndex == -1)
                return false;

            return true;
        }

        public void Insert(int index, object item)
        {
            if (count == arrayObject.Length)
            {
                Resize();
            }

            for (int i = arrayObject.Length - 1; i < index; i++)
            {
                arrayObject[i] = arrayObject[i - 1];
            }

            arrayObject[index] = item;
            count++;
        }

        public int IndexOf(object item)
        {
            for (int i = 0; i < arrayObject.Length; i++)
            {
                if (arrayObject[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Clear()
        {
            arrayObject = new object[INITIAL_CAPACITY];
            count = 0;
        }

        public object this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }
                return arrayObject[index];
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }

                arrayObject[index] = value;
            }
        }

        public void Resize()
        {
            object[] copy = new object[arrayObject.Length * 2];

            Array.Copy(arrayObject, copy, arrayObject.Length);

            arrayObject = copy;
        }
        
    }
}