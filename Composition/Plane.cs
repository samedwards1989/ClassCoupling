namespace Composition
{
    public class Plane : Vehicle
    {
        private readonly Flyable _flyable;

        public Plane(Flyable flyable)
        {
            _flyable = flyable;
            this.EngineSize = 6000;
            this.NumberOfWheels = 8;
            _flyable.Fly("plane");
        }
    }
}