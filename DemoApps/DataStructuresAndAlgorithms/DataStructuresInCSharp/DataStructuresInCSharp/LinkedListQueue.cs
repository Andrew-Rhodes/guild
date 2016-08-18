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
    public class LinkedListQueue : DataStructuresInCSharp.Queue
    {
        private Node first;
        private Node last;
        private int numItems;

        public  void enqueue(Object item)
        {
            // add to the end of the list
            Node prevLast = last;
            last = new Node();
            last.item = item;
            // if this is the fist node in the list set first equal to last
            if (isEmpty())
            {
                first = last;
            }
            else
            {
                // set the next pointer on prevLast to point to the new last
                prevLast.next = last;
            }
            numItems++;
        }

        public  Object dequeue()
        {
            // remove from the front of the list
            Object ret = first.item;
            first = first.next;
            numItems--;
            return ret;
        }

        public  bool isEmpty()
        {
            return first == null;
        }


        public  int size()
        {
            return numItems;
        }


        // This is needed for implementing IEnumerable
        // A good tutorial on this is http://www.codeproject.com/Articles/474678/A-Beginners-Tutorial-on-Implementing-IEnumerable-I

        public  IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private class Node
        {
            public Object item;
            public Node next;
        }


    }

}