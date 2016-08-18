using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableExample
{
    public class Temperature : IComparable
    {
        public double Fahrenheit { get; set; }
        public double Celsius { get { return (Fahrenheit - 32)*(5.0/9); } }

        public int CompareTo(object obj)
        {
            var otherTemperature = obj as Temperature;

            if (otherTemperature != null)
            {
                if (this.Fahrenheit < otherTemperature.Fahrenheit)
                {
                    return -1;
                }
                else if (this.Fahrenheit == otherTemperature.Fahrenheit)
                {
                    return 0;
                }
                else // this.Fahrenheit > otherTemperature.Fahrenheit
                {
                    return 1;
                }
            }
            else
            {
                throw new ArgumentException("Object is not a temperature!");
            }
        }
    }
}
