using System;

namespace Composition
{
    public class Flyable
    {
        public void Fly(string vehicle)
        {
            Console.WriteLine($"The {vehicle} is flying");
        }
    }
}