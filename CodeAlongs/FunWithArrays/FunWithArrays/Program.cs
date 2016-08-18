using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.IterateString();
            Program.SplitString();
            prog.SimpleArray();
            prog.ReverseString();
            prog.DeclareImplicitArrays();
            prog.RectMultiDimensionalArray();
            prog.JaggedMultiDimensionalArray();
            Console.ReadLine();
        }

        public void IterateString()
        {
            string s1 = "this is a string of characters.";

            foreach (char c in s1)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(s1.Length);
        }

        public static void SplitString()
        {
            Console.Clear();
            string[] words = "This is a sentence.".Split(' ');

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }

        public void SimpleArray()
        {
            Console.Clear();
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;

            // Hey, what's going to be at index 2
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
        }

        public void ReverseString()
        {
            Console.Clear();
            // ****************************************
            // YOU NEED TO KNOW THIS!!!!!!!
            // ****************************************
            string myString = "String to Reverse";

            for (int i = 0; i < myString.Length; i++)
            {
                Console.Write(myString[myString.Length - i - 1]);
            }

            Console.WriteLine();

            for (int i = myString.Length - 1; i >= 0; i--)
            {
                Console.Write(myString[i]);
            }
        }

        public void DeclareImplicitArrays()
        {
            Console.Clear();
            var a = new[] {1, 10, 100, 1000};
            Console.WriteLine("a is a: {0}", a.ToString());

            var b = new[] {1, 1.5, 2, 2.5};
            Console.WriteLine("b is a: {0}", b.ToString());

            var c = new[] {"hello", null, "world"};
            Console.WriteLine("c is a: {0}", c.ToString());
        }

        public void RectMultiDimensionalArray()
        {
            Console.Clear();
            int[,] myGrid = new int[5,6];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    myGrid[i, j] = i*j;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(myGrid[i,j] + "\t");
                }

                Console.WriteLine();
            }
        }

        public void JaggedMultiDimensionalArray()
        {
            Console.Clear();
            int[][] myJaggedArray = new int[5][];

            for (int i = 0; i < myJaggedArray.Length; i++)
            {
                myJaggedArray[i] = new int[i+3];
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJaggedArray[i].Length; j++)
                {
                    Console.Write(myJaggedArray[i][j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
