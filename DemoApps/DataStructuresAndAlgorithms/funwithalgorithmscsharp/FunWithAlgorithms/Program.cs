using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithAlgorithms
{
    class Program
    {
        public static void Main(string[] args)
        {
            SimpleSearch();
            BinarySearch();
            SelectionSort();
            QuickSort();

            Console.ReadLine();
        }

        public static void SimpleSearch()
        {
            int[] items = new int[] { 1, 3, 5, 7, 9, 2, 4, 6, 8 };
            int itemToFind = 8;
            SimpleSearch scout = new SimpleSearch();
            bool isFound = scout.Search(items, itemToFind);

            Console.WriteLine("Simple Search for " + itemToFind);
            Console.WriteLine(string.Join(" ", items));
            Console.WriteLine(isFound);
            Console.WriteLine();
        }

        public static void BinarySearch()
        {
            int[] items = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int itemToFind = 8;
            BinarySearch scout = new BinarySearch();
            bool isFound = scout.Search(items, itemToFind);

            Console.WriteLine("Bianry Search for " + itemToFind);
            Console.WriteLine(string.Join(" ", items));
            Console.WriteLine(isFound);
            Console.WriteLine();
        }

        public static void SelectionSort()
        {
            int[] items = new int[] { 7, 3, 6, 2, 9, 1, 8, 5, 4 };

            SelectionSort sorter = new SelectionSort();

            Console.WriteLine("Selection Sort");
            Console.WriteLine(string.Join(" ", items));

            sorter.Sort(items);

            Console.WriteLine(string.Join(" ", items));
            Console.WriteLine();
        }

        public static void QuickSort()
        {
            int[] items = new int[] { 3, 1, 4, 5, 2 };

            QuickSort sorter = new QuickSort();

            Console.WriteLine("Quick Sort");
            Console.WriteLine(string.Join(" ", items));

            sorter.Sort(items, 0, 4);

            Console.WriteLine(string.Join(" ", items));
            Console.WriteLine();
        }
    }
}
