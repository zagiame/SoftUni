using System;

namespace Vehicles
{
    public class Truck : Vehicle
    {

        private const double TruckAirModifier = 1.6;

        public Truck(double fuel, double consumption, double tankCapacity)
            : base(fuel, consumption, tankCapacity, TruckAirModifier)
        {

        }

        public override void Refuel(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException("Fuel must be a positive number");
            }

            if (Fuel + amount > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {amount} fuel in the tank");
            }

            this.Fuel += amount * 0.95;
        }
    }
}