using System;
using System.Collections.Generic;
using System.Text;

namespace QueueImplementation
{
    public class Node
    {
        int data;
        Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
