namespace ImplementLinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LinkedList<T>
    {
        private Node head; // first
        private Node tail; // last
        private int count;

        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void Add(T item)
        {
            Node element = new Node(item);

            if (head == null)
            {
                head = element;
                tail = element;
                count++;
            }
            else
            {
                Node current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = element;
            }
        }

        public int Remove(T item)
        {
            Node current = head;
            Node previous = null;

            int countIndexes = 0;
            bool isFound = false;
            while (current.Next != null)
            {
                if (current.Element.Equals(item))
                {
                    isFound = true;
                    break;
                }

                previous = current;
                current = current.Next;
                countIndexes++;
            }
            /*
            if (tail.Element.Equals(item)) // tail
            {
                previous.Next = null;
                tail = previous;
                count--;
            }
            */
            if (countIndexes == 0)
            {
                head = current.Next;
                count--;
            }
            else if (tail.Element.Equals(item))
            {
                previous.Next = null;
                tail = previous;
                countIndexes = count - 1;
                count--;
            }
            else if (isFound)
            {
                previous.Next = current.Next;
                count--;
            }
            else
            {
                countIndexes = -1;
            }
            if (count == 0)
            {
                head = null;
                tail = null;
            }

            return countIndexes;
        }

        public object Remove(int index)
        {
            if (index < 0 || index >= count)
            {
                return new ArgumentOutOfRangeException("invalid index: " + index);
            }

            int currentIndex = 0;

            Node currentNode = head;
            Node previous = null;

            while (currentIndex < index)
            {
                previous = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }

            count--;

            if (count == 0)
                head = tail = null;
            else if (previous == null)
                head = currentNode.Next;
            else
                previous.Next = currentNode.Next;

            return currentNode.Element;
        }

        public int Count { get => count; set => count = value; }

        public int IndexOf(T item)
        {
            int index = 0;
            Node current = head;
            while (current != null)
            {
                if (current.Element.Equals(item))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return
            -1;

        }
        public bool Contains(T item)
        {
            int index = IndexOf(item);
            bool found = (index != -1);

            return found;
        }


        public object this[int index]
        {
            get
            {
                if (index >= Count || index < 0)
                {


                    Node currentNode = this.head;
                    for (int i = 0; i < index; i++)
                    {
                        currentNode = currentNode.Next;
                    }

                    return currentNode.Element;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }
            }
            set
            {
                if (index >= Count || index < 0)
                {
                    Node currentNode = this.head;
                    for (int i = 0; i < index; i++)
                    {
                        currentNode = currentNode.Next;
                    }

                    currentNode.Element = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("invalid index: " + index);
                }
            }
        }
    }
}