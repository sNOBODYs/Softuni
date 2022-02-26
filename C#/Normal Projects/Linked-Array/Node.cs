namespace ImplementLinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Node
    {
        public Node(object element, Node next = null)
        {
            Element = element;
            Next = next;
        }

        public object Element { get; set; }

        public Node Next { get; set; }
    }
}