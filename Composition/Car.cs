namespace Composition
{
    public class Car : Vehicle
    {
        private readonly Drivable _drivable;

        public Car(Drivable drivable)
        {
            _drivable = drivable;
            this.EngineSize = 1600;
            this.NumberOfWheels = 4;
            _drivable.Drive("car");
        }
    }
}