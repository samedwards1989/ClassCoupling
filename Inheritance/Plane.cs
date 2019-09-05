namespace Inheritance
{
    public class Plane : Vehicle
    {
        public Plane()
        {
            this.EngineSize = 6000;
            this.NumberOfWheels = 8;

            // Issue here as Planes do not drive
            this.Drive("plane");
        }
    }
}