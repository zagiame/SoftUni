using System;
using System.Linq;
using System.Text;
using EasterRaces.Core.Contracts;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Models.Races.Entities;
using EasterRaces.Repositories.Contracts;
using EasterRaces.Repositories.Entities;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Core.Entities
{
    public class ChampionshipController : IChampionshipController
    {
        private const int minRaceParticipants = 3;

        private readonly IRepository<IDriver> driverRepository;
        private readonly IRepository<ICar> carsRepository;
        private readonly IRepository<IRace> raceRepository;

        public ChampionshipController()
        {
            driverRepository = new DriverRepository();
            carsRepository = new CarRepository();
            raceRepository = new RaceRepository();
        }

        public string CreateDriver(string driverName)
        {
            IDriver driver = new Driver(driverName);
            driverRepository.Add(driver);

            return string.Format(OutputMessages.DriverCreated, driverName);
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            ICar car = null;

            if (type == "Muscle")
            {
                car = new MuscleCar(model, horsePower);
            }

            else if (type == "Sports")
            {
                car = new SportsCar(model, horsePower);
            }

            type = type + "Car";
            carsRepository.Add(car);

            return string.Format(OutputMessages.CarCreated, type, model);
        }

        public string CreateRace(string name, int laps)
        {
            IRace race = new Race(name, laps);
            raceRepository.Add(race);

            return string.Format(OutputMessages.RaceCreated, name);
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            IRace race = this.raceRepository.GetByName(raceName);
            IDriver driver = this.driverRepository.GetByName(driverName);

            if (race == null)
            {
                throw new InvalidOperationException
                    (string.Format(ExceptionMessages.RaceNotFound, raceName));
            }

            if (driver == null)
            {
                throw new InvalidOperationException
                    (string.Format(ExceptionMessages.DriverNotFound, driverName));
            }

            race.AddDriver(driver);
            return string.Format(OutputMessages.DriverAdded, driverName, raceName);
        }

        public string AddCarToDriver(string driverName, string carModel)
        {
            IDriver driver = this.driverRepository.GetByName(driverName);
            ICar car = this.carsRepository.GetByName(carModel);

            if (driver == null)
            {
                throw new InvalidOperationException
                    (string.Format(ExceptionMessages.DriverNotFound, driverName));
            }

            if (car == null)
            {
                throw new InvalidOperationException
                    (string.Format(ExceptionMessages.CarNotFound, carModel));
            }

            driver.AddCar(car);
            return string.Format(OutputMessages.CarAdded, driverName, carModel);
        }

        public string StartRace(string raceName)
        {
            IRace race = this.raceRepository.GetByName(raceName);

            if (race == null)
            {
                throw new InvalidOperationException
                    (string.Format(ExceptionMessages.RaceNotFound, raceName));
            }

            if (race.Drivers.Count < minRaceParticipants)
            {
                throw new InvalidOperationException
                    (string.Format(ExceptionMessages.RaceInvalid, raceName, minRaceParticipants));
            }

            var winners = race.Drivers
                .OrderByDescending
                (first => first.Car.CalculateRacePoints(race.Laps))
                .Take(3)
                .ToArray();

            this.raceRepository.Remove(race);
            var firstWinner = winners[0];
            var secondWinner = winners[1];
            var thirdWinner = winners[2];

            var text = new StringBuilder();
            text.AppendLine(string.Format(OutputMessages.DriverFirstPosition, firstWinner, raceName));
            text.AppendLine(string.Format(OutputMessages.DriverSecondPosition, secondWinner, raceName));
            text.AppendLine(string.Format(OutputMessages.DriverThirdPosition, thirdWinner, raceName));

            return text.ToString().TrimEnd();
        }
    }
}