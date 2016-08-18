using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunWithCollections.Collections;

namespace FunWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            NonGenerics.ShowArrayList();
            NonGenerics.ShowHashTable();
            NonGenerics.ShowStack();
            NonGenerics.ShowQueue();

            Generics obj = new Generics();
            obj.ShowStack();
            obj.ShowQueue();
            obj.SimpleList();
            obj.PersonDictionary();
            Console.ReadLine();
        }
    }
}
