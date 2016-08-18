using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FunWithAlgorithms
{
    public class SelectionSort
    {
        public void Sort(int[] items)
        {
            for (int i = 0; i < items.Count() - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < items.Count(); j++)
                {
                    if (items[j] < items[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    int temp = items[i];
                    items[i] = items[min];
                    items[min] = temp;
                }
            }
        }
    }
}
