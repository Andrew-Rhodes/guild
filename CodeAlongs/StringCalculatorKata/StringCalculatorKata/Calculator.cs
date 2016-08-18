using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            else
            {
                char[] delimiters;
                if (!numbers.StartsWith("//"))
                {
                    delimiters = new char[] { ',', '\n' };
                }
                else
                {
                    string[] parts = numbers.Split('\n');
                    numbers = parts[1];
                    delimiters = parts[0].Substring(2).ToCharArray();
                }

                string[] individualNumbers = numbers.Split(delimiters);

                int result = 0;
                
                for (int i = 0; i < individualNumbers.Length; i++)
                {
                    result = result + int.Parse(individualNumbers[i]);
                }

                return result;
            }
            
        }
    }
}
