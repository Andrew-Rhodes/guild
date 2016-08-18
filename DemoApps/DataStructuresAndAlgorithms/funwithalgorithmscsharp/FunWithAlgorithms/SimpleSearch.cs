using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithAlgorithms
{
    public class SimpleSearch
    {
        public bool Search(int[] items, int itemToFind)
        {
            bool isFound = false;

            for (int i = 0; i < items.Count(); i++)
            {
                if (items[i] == itemToFind)
                {
                    isFound = true;
                    break;
                }
            }

            return isFound;
        }
    }
}
