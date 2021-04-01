namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double BusAirModifier = 1.4;

        public Bus(double fuel, double consumption, double tankCapacity)
            : base(fuel, consumption, tankCapacity, BusAirModifier)
        {

        }
    }
}