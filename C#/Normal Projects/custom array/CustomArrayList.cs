using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace iteratorsExer
{
    public class arrlist<T> : IEnumerable<T>
    {

        private T[] arrayObject;

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

        public arrlist()
        {
            arrayObject = new T[INITIAL_CAPACITY];
            count = 0;
        }

        public void Add(T item)
        {
            Insert(count, item);
        }

        public T Remove(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }

            T item = arrayObject[index];

            arrayObject[index] = default;

            for (int i = index; i < arrayObject.Length - 1; i++)
            {
                arrayObject[i] = arrayObject[i + 1];
            }

            arrayObject[count - 1] = default;
            count--;

            if (count <= arrayObject.Length / 2)
            {
                Shrink();
            }

            return item;
        }

        private void Shrink()
        {
            T[] copy = new T[arrayObject.Length / 2];

            Array.Copy(arrayObject, copy, copy.Length);

            arrayObject = copy;
        }

        public int Remove(T item)
        {
            int index = IndexOf(item);

            if (index == -1)
            {
                return index;
            }
            Remove(index);

            return index;
        }

        public bool Contains(T item)
        {
            int currentIndex = IndexOf(item);

            if (currentIndex == -1)
                return false;

            return true;
        }

        public void Insert(int index, T item)
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

        public int IndexOf(T item)
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
            arrayObject = new T[INITIAL_CAPACITY];
            count = 0;
        }

        public T this[int index]
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

        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return GetEnumerator();
        }
    }
}
