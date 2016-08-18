using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresInCSharp
{

    /**
     *
     * @author apprentice
     */
    public class LinkedListStack : DataStructuresInCSharp.Stack
    {
        private Node first;
        private int numItems;

        public bool isEmpty()
        {
            return first == null;
        }

        public int size()
        {
            return numItems;
        }

        public void push(Object item)
        {
            Node prevFirst = first;
            first = new Node();
            first.item = item;
            first.next = prevFirst;
            numItems++;
        }

        public Object pop()
        {
            Object ret = first;
            if (ret != null)
            {
                ret = first.item;
                first = first.next;
                numItems--;
            }
            return ret;
        }

        // This is needed for implementing IEnumerable
        // A good tutorial on this is http://www.codeproject.com/Articles/474678/A-Beginners-Tutorial-on-Implementing-IEnumerable-I

        public IEnumerator GetEnumerator()
        {
            for (int n = 0; n <= numItems; n++)
            {
                if (first == null)
                {
                    break;
                }
                Node current = first;
                first = first.next; 
                yield return current.item;
            }
        }

        private class Node
        {
            public Object item;
            public Node next;
        }


    }

}