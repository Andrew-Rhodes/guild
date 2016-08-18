using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresInCSharp {

public class LinkedList : IEnumerable{

    private Node first;
    private Node last;
    private int numItems = 0;

    public void prepend(Object item) {
        // insert at front of list - just like stack
        Node prevFirst = first;
        first = new Node();
        first.item = item;
        first.next = prevFirst;
        numItems++;
        // if numItems is 1 this is the first and last Node
        if (numItems == 1) {
            last = first;
        }
    }

    // adds to end of list
    public void append(Object item) {
        // add to end of list - just like queue
        Node prevLast = last;
        last = new Node();
        last.item = item;
        prevLast.next = last;
        numItems++;
    }

    // inserts after the given index
    public void insert(int index, Object item) {
        // if we're appending to the end just call append so we don't
        // iterate through the list
        if (index == numItems - 1) {
            append(item);
        } else {
            // get node at index
            Node nodeAtIndex = getNode(index);
            if (nodeAtIndex == null)
            {
                return;
            }

            // insert new node after node at index
            Node newNode = new Node();
            newNode.item = item;
            newNode.next = nodeAtIndex.next;
            nodeAtIndex.next = newNode;
            numItems++;
        }
    }

    public Object get(int index) {
        if (index == 0) {
            return first.item;
        } else if (index == numItems - 1) {
            return last;
        } else {
            // find the item in the list
            return getNode(index).item;
        }
    }

    public Object remove(int index) {
        Object ret = null;
        if (index == 0) {
            // if index is 0 remove the first Node - just like a Stack pop
            ret = first.item;
            first = first.next;
        } else {
            // find the Node BEFORE the one we want to remove
            Node nodeBefore = getNode(index - 1);
            // get the item from the Node we want to remove
            if (nodeBefore == null)
            {
                return ret;
            }
            ret = nodeBefore.next.item;
            // point our next to the node AFTER the one we want to remove
            nodeBefore.next = nodeBefore.next.next;
            // if we removed the last node in the list we need to point last to
            // nodeBefore
            if (index == numItems - 1) {
                last = nodeBefore;
            }
        }
        numItems--;
        return ret;
    }

    public int size() {
        return numItems;
    }

    public bool isEmpty() {
        return numItems == 0;
    }

    // This is needed for implementing IEnumerable
    // A good tutorial on this is http://www.codeproject.com/Articles/474678/A-Beginners-Tutorial-on-Implementing-IEnumerable-I
    
    public IEnumerator GetEnumerator() {
        for (int i = 0; i < numItems; i++)
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

    private class Node {
        public Object item;
        public Node next;
    }

    

    // finds the Node at the given index
    private Node getNode(int index) {
        if (index > numItems - 1 || index < 0) {
            throw new IndexOutOfRangeException("Index out of bounds.  Must be between 0 and "
                    + (numItems - 1) + " inclusive.");
        }
        if (first == null)
        {
            return first;
        }

        Node nodeAtIndex = first;
        for (int i = 0; i < index; i++) {
            nodeAtIndex = nodeAtIndex.next;
        }

        return nodeAtIndex;
    }

}
}