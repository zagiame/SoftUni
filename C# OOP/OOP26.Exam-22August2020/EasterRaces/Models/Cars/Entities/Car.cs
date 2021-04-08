using System;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Models.Cars.Entities
{
    public abstract class Car : ICar
    {
        private string model;
        private int horsePower;
        private int minHorsePower;
        private int maxHorsePower;

        public Car(string model, int horsePower, double cubicCentimeters, int minHorsePower, int maxHorsePower)
        {
            this.minHorsePower = minHorsePower;
            this.maxHorsePower = maxHorsePower;

            this.Model = model;
            this.HorsePower = horsePower;
            this.CubicCentimeters = cubicCentimeters;
        }

        public string Model
        {
            get => model;

            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidModel);
                }

                else
                {
                    model = value;
                }
            }

        }

        public int HorsePower
        {
            get => horsePower;

            private set
            {
                if (value < minHorsePower || value > maxHorsePower)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidHorsePower);
                }

                else
                {
                    horsePower = value;
                }
            }
        }

        public double CubicCentimeters { get; private set; }


        public double CalculateRacePoints(int laps)
        {
            return CubicCentimeters / HorsePower * laps;
        }
    }
}