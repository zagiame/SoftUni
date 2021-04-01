namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double CarAirModifier = 0.9;


        public Car(double fuel, double consumption, double tankCapacity) 
            : base(fuel, consumption, tankCapacity, CarAirModifier)
        {
        }
    }
}