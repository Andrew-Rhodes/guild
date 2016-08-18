using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresInCSharp
{
    /*
     * @author apprentice
     */
    public class GenLinkedListStack<T> : GenStack<T>
    {
        private Node<T> first;
        private int numItems;


        public bool isEmpty()
        {
            return first == null;
        }

        public int size()
        {
            return numItems; 
        }

        public void push(T item)
        {
            Node<T> prevFirst = first;
            first = new Node<T>();
            first.item = item;
            first.next = prevFirst;
            numItems++;
        }

        public T pop()
        {
            T ret = first.item;
            first = first.next;
            numItems--;
            return ret;
        }

        // This is needed for implementing IEnumerable
        // A good tutorial on this is http://www.codeproject.com/Articles/474678/A-Beginners-Tutorial-on-Implementing-IEnumerable-I
        public IEnumerator GetEnumerator()
        {
            //    return new LinkedListIterator();
            throw new NotImplementedException("Gotta keep em enumerated");
        }

        private class Node<T>
        {
            public T item;
            public Node<T> next;
        }

    }
}