using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresInCSharp {


/**
 *
 * @author apprentice
 */
public class ArrayQueue : DataStructuresInCSharp.Queue {

    private static readonly int DEFAULT_INITIAL_SIZE = 4;
    private Object[] items;
    private int numItems = 0;
    private int head = 0;
    private int tail = 0;

    public ArrayQueue() {
        items = new Object[DEFAULT_INITIAL_SIZE];
    }

    public ArrayQueue(int size) {
        items = new Object[size];
    }
    
    public  void enqueue(Object item) {
        // check to see if this will fill up the array
        items[tail++] = item;
        // check to see if the tail went off the end of the array
        // reset it to 0 if that is the case
        if (tail == items.Length)
        {
            tail = 0;
        }
        if (++numItems == items.Length)
        {
            resize(2 * items.Length);
        }
    }

    public  Object dequeue() {
        if (numItems == 0) {
            return null;
        }
        Object ret = items[head];
        // get rid of our reference
        items[head++] = null;
        // check to see if the head went off the end of the array
        // reset to 0 if that is the case
        if (head == items.Length)
        {
            head = 0;
        }
        // check to see if we should downsize the array
        if (--numItems == items.Length / 4)
        {
            resize(items.Length / 2);
        }

        return ret;
    }

    
    public  bool isEmpty() {
        return numItems == 0;
    }

    public  int size() {
        return numItems;
    }

    // This is needed for implementing IEnumerable
    // A good tutorial on this is http://www.codeproject.com/Articles/474678/A-Beginners-Tutorial-on-Implementing-IEnumerable-I   
    public  IEnumerator GetEnumerator() {
        //return new InOrderArrayIterator();
        throw new NotImplementedException("Enumerating not found");
    }

    private void resize(int newSize) {
        Object[] temp = new Object[newSize];
        // fill the new array from the front and reset the head and tail
        // pointers appropriately
        for (int i = 0, current = head; i < numItems; i++, current++) {
            temp[i] = items[current % items.Length];
        }

        head = 0;
        tail = numItems;
        items = temp;
    }

 
}
}