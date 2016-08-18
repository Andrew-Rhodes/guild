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
    public class GenArrayStack<T> : GenStack<T>
    {

        private static readonly int DEFAULT_INITIAL_SIZE = 4;
        private T[] items;
        private int numItems;

        public GenArrayStack()
        {
            items = new T[DEFAULT_INITIAL_SIZE];
        }

        public GenArrayStack(int size)
        {
            items = new T[size];
        }

        public  bool isEmpty()
        {
            return numItems == 0;
        }

        public  int size()
        {
            return numItems;
        }


        public  void push(T item)
        {
            if (numItems == items.Length)
            {
                resize(2 * items.Length);
            }
            items[numItems++] = item;
        }

        public  T pop()
        {
            if (numItems == 0)
            {
                return default(T);
            }
            T item = items[--numItems];
            items[numItems] = default(T);
            if (numItems > 0 && numItems == items.Length / 4)
            {
                resize(items.Length / 2);
            }
            return item;
        }

        // Second step
        private void resize(int newSize)
        {
            T[] temp = new T[newSize];
            for (int i = 0; i < numItems; i++)
            {
                temp[i] = items[i];
            }
            items = temp;
        }

        // This is needed for implementing IEnumerable
        // A good tutorial on this is http://www.codeproject.com/Articles/474678/A-Beginners-Tutorial-on-Implementing-IEnumerable-I
        public  IEnumerator GetEnumerator()
        {
            foreach (T t in items)
            {
                if (t == null)
                {
                    break;
                }
                yield return t;
            }
            //return new ReverseArrayIterator();
            throw new NotImplementedException("Enumerate, enumerate, how's that iterate?");
        }

    }
}
