﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace launchPad
{
    class LinkedList
    {

    }

    class Node
    {
        Node next = null;
        int data;
        public Node(int d)
        {
            data = d;
        }
        void AppendToTail(int d)
        {
            Node end = new Node(d);
            Node n = this;
            while (n.next != null)
            {
                n = n.next;
            }
            n.next = end;
        }
    }
}