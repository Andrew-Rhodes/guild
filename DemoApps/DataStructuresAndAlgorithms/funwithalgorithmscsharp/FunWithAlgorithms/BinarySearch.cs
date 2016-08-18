using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithAlgorithms
{
    public class BinarySearch
    {
        public bool Search(int[] items, int itemToFind)
        {
            bool isFound = false;

            int low = 0;
            int high = items.Count();

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (items[mid] == itemToFind)
                {
                    isFound = true;
                    break;
                }
                else if (items[mid] < itemToFind)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return isFound;
        }
    }
}
