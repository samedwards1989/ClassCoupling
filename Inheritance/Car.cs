namespace Inheritance
{
    public class Car : Vehicle
    {
        public Car()
        {
            this.EngineSize = 1600;
            this.NumberOfWheels = 4;
            this.Drive("car");
        }
    }
}