using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTreeBalancing
{
    class Program
    {
        static void Main(string[] args)
        {
            BTree tree = new BTree();
            tree.Add(10);
            tree.Add(14);
            tree.Add(4);
            tree.Add(9);
            tree.Add(17);
            tree.Add(0);
            tree.Add(12);
            tree.Add(1);
            tree.Add(6);
            tree.Add(15);
            tree.Add(14);
            tree.Add(10);
            tree.Add(1);

            tree.Write(tree.First);

            Console.ReadLine();
        }
    }
}
