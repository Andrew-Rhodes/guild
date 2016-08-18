using System;

namespace TrafficLightDemo
{
    class Program
    {
        static void Main()
        {
            // create a traffic light
            TrafficLight light = new TrafficLight();
            
            // print the initial color of the light
            PrintValue(light);

            // change the light color and print
            light.ChangeColor();
            PrintValue(light);

            // change the light color again
            light.ChangeColor();
            PrintValue(light);

            // one last time
            light.ChangeColor();
            PrintValue(light);

            Console.ReadLine();
        }

        static void PrintValue(TrafficLight light)
        {
            // write the numeric value as well as the enum value. 
            Console.WriteLine("The light has a value of {0} which is the color {1}",
                (int)light.CurrentColor, light.CurrentColor);
        }
    }
}
