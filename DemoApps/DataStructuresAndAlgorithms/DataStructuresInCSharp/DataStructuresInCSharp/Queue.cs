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
interface Queue : IEnumerable {
    
    void enqueue(Object item);
    Object dequeue();
    bool isEmpty();
    int size();

    // This is needed for implementing IEnumerable
    // A good tutorial on this is http://www.codeproject.com/Articles/474678/A-Beginners-Tutorial-on-Implementing-IEnumerable-I
    IEnumerator GetEnumerator(); 
}

}