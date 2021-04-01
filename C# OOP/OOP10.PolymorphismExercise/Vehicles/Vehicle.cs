using System;

namespace Vehicles
{
    public class Vehicle
    {
        private double fuel;
        private double tankCapacity;

        public Vehicle(double fuel, double consumption, double tankCapacity, double airConditioner)
        {
            TankCapacity = tankCapacity;
            Fuel = fuel;
            Consumption = consumption;
            AirConditioner = airConditioner;
        }

        private double AirConditioner { get; set; }

        public double Fuel
        {
            get => fuel;

            protected set
            {
                if (value > TankCapacity)
                {
                    fuel = 0;
                }

                else
                {
                    fuel = value;
                }
            }
        }

        public double Consumption { get; private set; }

        public double TankCapacity { get; private set; }

        public virtual void Drive(double distance)
        {
            var requiredFuel = (Consumption + AirConditioner) * distance;

            if (Fuel < requiredFuel)
            {
                throw new InvalidOperationException($"{GetType().Name} needs refueling");
            }

            Fuel -= requiredFuel;
        }

        public virtual void DriveEmpty(double distance)
        {
            var requiredFuel = Consumption * distance;

            if (Fuel < requiredFuel)
            {
                throw new InvalidOperationException($"{GetType().Name} needs refueling");
            }

            Fuel -= requiredFuel;
        }


        public virtual void Refuel(double amount)
        {

            if (amount <= 0)
            {
                throw new InvalidOperationException("Fuel must be a positive number");
            }

            if (Fuel + amount > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {amount} fuel in the tank");
            }

            Fuel += amount;
        }

    }
}