using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTreeBalancing
{
    public class BTree
    {
        public Node First;

        public void Add(int item)
        {
            if (First == null)
            {
                First = Create(item);
            }
            else
            {
                Node prevParent = null;
                Node node = First;
                bool isLeft = false;
                while (node != null)
                {
                    prevParent = node;
                    if (item < node.item)
                    {
                        node = node.leftChild;
                        isLeft = true;
                    }
                    else
                    {
                        node = node.rightChild;
                        isLeft = false;
                    }
                }

                if (isLeft)
                {
                    prevParent.leftChild = Create(item);
                }
                else
                {
                    prevParent.rightChild = Create(item);
                }
            }
        }

        public void Write(Node node)
        {
            if (node != null)
            {
                Write(node.leftChild);
                Console.Write($"{node.item} ");
                Write(node.rightChild);
            }
        }

        private Node Create(int item)
        {
            Node node = new Node();
            node.item = item;
            node.rightChild = null;
            node.leftChild = null;

            return node;
        }

        public class Node
        {
            public int item;
            public Node rightChild;
            public Node leftChild;
        }
    }
}
