﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int value = calc.Add("");

            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}