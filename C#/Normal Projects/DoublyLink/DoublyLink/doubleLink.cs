using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLink
{
    class doubleLink
    {
        private Node head;
        private Node tail;

        private int Count { get; set; }

        public void AddFirst(object element)
        {
            Node currentNode = new Node(element);

            if (Count == 0)
            {
                head = tail = currentNode;
                Count++;
            }
            else
            {
                head.Previous = currentNode;
                currentNode.Next = head;

                head = currentNode;
                Count++;
            }

        }

        public void AddList(object element)
        {
            Node currentNode = new Node(element);
            if (Count == 0)
            {
                head = tail = currentNode;
                Count++;
            }
            else
            {
                tail.Next = currentNode;
                currentNode.Previous = tail;

                tail = currentNode;
                Count++;
            }

        }
        public object GetFirst()
        {
            IsEmpty();
            return head.Element;
        }
        public object GetLast()
        {
            IsEmpty();
            return tail.Element;
        }
        public void RemoveFirst()
        {
            IsEmpty();
            if (Count == 1)
            {
                tail = head = null;
            }
            else
            {
                head = head.Next;
                head.Previous = null;
                Count--;
            }

        }
        public void RemoveLasr()
        {
            IsEmpty();
            if (Count == 1)
            {
                tail = head = null;
            }
            else
            {
                tail = tail.Previous;
                tail.Next = null;
                Count--;
            }

        }
        public void IsEmpty()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Linked List is empty!");
            }
        }
    }
}
