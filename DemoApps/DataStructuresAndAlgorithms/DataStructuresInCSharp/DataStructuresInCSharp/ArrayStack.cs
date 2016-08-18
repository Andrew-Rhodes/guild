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
    public class ArrayStack : Stack
    {
        private static readonly int DEFAULT_INITIAL_SIZE = 4;
        private Object[] items;
        private int numItems;

        public ArrayStack()
        {
         
            items = new Object[DEFAULT_INITIAL_SIZE];
        }

        public ArrayStack(int size)
        {
            items = new Object[size];
        }


        public  bool isEmpty()
        {
            return numItems == 0;
        }


        public  int size()
        {
            return numItems;
        }


        public  void push(Object item)
        {
            if (numItems == items.Length)
            {
                resize(2 * items.Length);
            }
            items[numItems++] = item;
        }


        public  Object pop()
        {
            if (numItems == 0)
            {
                return null;
            }
            Object item = items[--numItems];
            items[numItems] = null;
            if (numItems > 0 && numItems == items.Length / 4)
            {
                resize(items.Length / 2);
            }
            return item;
        }

        // Second step
        private void resize(int newSize)
        {
            Object[] temp = new Object[newSize];
            for (int i = 0; i < numItems; i++)
            {
                temp[i] = items[i];
            }
            items = temp;
        }

        // This is needed for implementing IEnumerable
        // A good tutorial on this is http://www.codeproject.com/Articles/474678/A-Beginners-Tutorial-on-Implementing-IEnumerable-I
        public IEnumerator GetEnumerator()
        {
            // return new ReverseArrayIterator();
            throw new NotImplementedException("detnemelpmi ton yarrA");
        }

        
    }
}
