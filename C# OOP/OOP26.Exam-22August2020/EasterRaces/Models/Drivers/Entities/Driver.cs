using System;
using System.Collections.Generic;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Models.Drivers.Entities
{
    public class Driver : IDriver
    {
        private const int minSymbol = 5;
        private string name;

        public Driver(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get => name;

            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < minSymbol)
                {
                    throw new ArgumentException
                        (string.Format(ExceptionMessages.InvalidName, value, minSymbol));
                }

                else
                {
                    name = value;
                }
            }
        }
        public ICar Car { get; private set; }

        public int NumberOfWins { get; private set; }

        public bool CanParticipate => this.Car != null;

        public void WinRace()
        {
            NumberOfWins++;
        }

        public void AddCar(ICar car)
        {
            if (car == null)
            {
                throw new ArgumentNullException
                    (ExceptionMessages.CarInvalid);
            }

            else
            {
                this.Car = car;
            }
        }
    }
}