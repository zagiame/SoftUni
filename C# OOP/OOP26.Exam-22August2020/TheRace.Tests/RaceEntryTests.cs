using System;
using NUnit.Framework;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private RaceEntry race;

        [SetUp]
        public void Setup()
        {
            race = new RaceEntry();
        }

        [Test]
        public void Add_ThrowException_IsNull()
        {
            Assert.Throws<InvalidOperationException>(() => race.AddDriver(null));
        }

        [Test]
        public void Add_ThrowException_DriverAlreadyExist()
        {
            var name = "ivan";
            var car = new UnitCar("model", 10, 10);
            UnitDriver driver = new UnitDriver(name, car);

            race.AddDriver(driver);
            Assert.Throws<InvalidOperationException>(() => race.AddDriver(driver));
        }

        [Test]
        public void Add_IsWorking()
        {
            var name = "ivan";
            var car = new UnitCar("model", 10, 10);
            UnitDriver driver = new UnitDriver(name, car);

            race.AddDriver(driver);
            Assert.That(race.Counter == 1);
        }

        [Test]
        public void Calculate_ThrowException_ZeroParticipants()
        {
            Assert.Throws<InvalidOperationException>(() => race.CalculateAverageHorsePower());
        }

        [Test]
        public void Calculate_ThrowException_OneParticipants()
        {
            var name = "ivan";
            var car = new UnitCar("model", 10, 10);
            UnitDriver driver = new UnitDriver(name, car);

            race.AddDriver(driver);
            Assert.Throws<InvalidOperationException>(() => race.CalculateAverageHorsePower());
        }

        [Test]
        public void Calculate_IsWorking()
        {
            var firstName = "driver: 1";
            var firstPower = 10;
            var firstCar = new UnitCar("car: 1", firstPower, 10);
            UnitDriver firstDriver = new UnitDriver(firstName, firstCar);

            var secondName = "driver: 2";
            var secondPower = 10;
            var seoncdCar = new UnitCar("car: 2", secondPower, 10);
            UnitDriver secondDriver = new UnitDriver(secondName, seoncdCar);

            race.AddDriver(firstDriver);
            race.AddDriver(secondDriver);
            var test = race.CalculateAverageHorsePower();

            var count = race.Counter;
            var sumPower = firstPower + secondPower;
            double compare = sumPower / count;
            Assert.That(race.CalculateAverageHorsePower() == compare);
        }
    }
}