using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithAlgorithms
{
    public class QuickSort
    {
        public void Sort(int[] items, int low, int high)
        {
            if (items == null || items.Count() == 0)
                return;

            if (low >= high)
                return;

            // pick the pivot
            int middle = low + (high - low) / 2;
            int pivot = items[middle];

            // make left < pivot and right > pivot
            int i = low, j = high;
            while (i <= j)
            {
                while (items[i] < pivot)
                {
                    i++;
                }

                while (items[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = items[i];
                    items[i] = items[j];
                    items[j] = temp;
                    i++;
                    j--;
                }
            }

            // recursively sort two sub parts
            if (low < j)
                Sort(items, low, j);

            if (high > i)
                Sort(items, i, high);
        }
    }
}
