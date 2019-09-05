using System;

namespace Composition
{
    public class Drivable
    {
        public void Drive(string vehicle)
        {
            Console.WriteLine($"The {vehicle} is driving.");
        }
    }
}