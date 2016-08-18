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
interface GenStack <T> : IEnumerable{
    
    bool isEmpty();
    
    int size();
    
    void push(T item);
    
    T pop();

    // This is needed for implementing IEnumerable
    // A good tutorial on this is http://www.codeproject.com/Articles/474678/A-Beginners-Tutorial-on-Implementing-IEnumerable-I
    IEnumerator GetEnumerator(); 
        
}
}