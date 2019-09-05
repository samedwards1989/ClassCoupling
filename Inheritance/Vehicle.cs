using System;

namespace Inheritance
{
    public class Vehicle
    {
        public int NumberOfWheels { get; set; }
        public int EngineSize { get; set; }

        public void Drive(string vehicle)
        {
            Console.WriteLine($"The {vehicle} is driving");
        }
    }
}