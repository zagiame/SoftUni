using System;
using System.Collections.Generic;
using System.Linq;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Models.Races.Entities
{
    public class Race : IRace
    {
        private const int minSymbol = 5;
        private const int minLaps = 1;

        private string name;
        private int laps;
        private readonly IDictionary<string, IDriver> driversByName;

        public Race(string name, int laps)
        {
            Name = name;
            Laps = laps;

            driversByName = new Dictionary<string, IDriver>();
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

        public int Laps
        {
            get => laps;

            private set
            {
                if (value < minLaps)
                {
                    throw new ArgumentException
                        (string.Format(ExceptionMessages.InvalidNumberOfLaps, minLaps));
                }

                else
                {
                    laps = value;
                }
            }

        }

        public IReadOnlyCollection<IDriver> Drivers => driversByName.Values.ToList();

        public void AddDriver(IDriver driver)
        {
            if (driver == null)
            {
                throw new ArgumentNullException
                    (ExceptionMessages.DriverInvalid);
            }

            if (driver.CanParticipate == false)
            {
                throw new ArgumentNullException
                    (string.Format(ExceptionMessages.DriverNotParticipate, driver.Name));
            }

            if (driversByName.ContainsKey(driver.Name))
            {
                throw new ArgumentNullException
                    (string.Format(ExceptionMessages.DriverAlreadyAdded, driver.Name, this.Name));
            }

            else
            {
                driversByName.Add(driver.Name, driver);
            }
        }
    }
}