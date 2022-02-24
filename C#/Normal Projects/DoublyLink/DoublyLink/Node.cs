using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLink
{
    class Node
    {
       public object Element;
       public Node Next;
       public Node Previous;
       public Node(object element)
       {
                Element = element;
       }
       
    }
}

