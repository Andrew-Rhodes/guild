using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    public class Car
    {
        // public properties
        public int MaxSpeed { get; set; }
        public int MinSpeed { get; set; }

        // public property with private field
        private int _currentSpeed;

        public int Speed
        {
            get { return _currentSpeed;}
            set
            {
                _currentSpeed = value;
                if (_currentSpeed > MaxSpeed)
                {
                    _currentSpeed = MaxSpeed;
                }
            }
        }

        // default constructor
        public Car()
        {
            MaxSpeed = 100;
            MinSpeed = 0;
        }

        // another constructor
        public Car(int max)
        {
            MaxSpeed = max;
            MinSpeed = 0;
        }

        // another overload for the constructor
        public Car(int max, int min)
        {
            MaxSpeed = max;
            MinSpeed = min;
        }
    }
}
