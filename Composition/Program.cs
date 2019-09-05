using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var drivable = new Drivable();
            var car = new Car(drivable);

            var flyable = new Flyable();
            var plane = new Plane(flyable);
        }
    }
}
