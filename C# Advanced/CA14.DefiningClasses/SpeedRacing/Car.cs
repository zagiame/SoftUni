using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        // field
        private string model;
        private double fuel;
        private double consumation;
        private double distance;

        // constructor

        // proprety
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        // method
        public bool Drive(double distanceTraveled)
        {
            double neededFuel = distanceTraveled * this.FuelConsumptionPerKilometer;

            if (neededFuel > this.FuelAmount)
            {
                return false;
            }

            this.FuelAmount = this.FuelAmount - neededFuel;
            this.TravelledDistance = this.TravelledDistance + distanceTraveled;
            return true;
        }

    }
}
