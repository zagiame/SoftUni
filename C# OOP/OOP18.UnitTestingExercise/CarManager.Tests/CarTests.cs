using System;
using CarManager;
using NUnit.Framework;

namespace Tests
{
    public class CarTests
    {
        private Car car;
        private string make = "make";
        private string model = "model";
        private double fuelConsumption = 10.00;
        private double fuelCapacity = 100.00;


        [SetUp]
        public void Setup()
        {
            car = new Car(make, model, fuelConsumption, fuelCapacity);
        }

        [Test]
        [TestCase("", "model", 10, 100)]
        [TestCase(null, "model", 10, 100)]
        [TestCase("make", "", 10, 100)]
        [TestCase("make", null, 10, 100)]
        [TestCase("make", "model", 0, 100)]
        [TestCase("make", "model", -10, 100)]
        [TestCase("make", "model", 10, 0)]
        [TestCase("make", "model", 10, -100)]
        public void Ctor_ThrowException_WhenDataIsInvalid
            (string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() =>
                new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        public void Ctor_SetValue()
        {
            Assert.That(car.Make == make);
            Assert.That(car.Model == model);
            Assert.That(car.FuelConsumption == fuelConsumption);
            Assert.That(car.FuelCapacity == fuelCapacity);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-10)]
        public void Refuel_ThrowException_WhenDataIsInvalid(double invalidFuel)
        {
            Assert.Throws<ArgumentException>(() => car.Refuel(invalidFuel));
        }

        [Test]
        public void Refuel_IsCorrect()
        {
            double toRefuel = 50;
            double maxRefuel = 100;
            double compare = toRefuel + car.FuelAmount;

            car.Refuel(toRefuel);
            Assert.That(car.FuelAmount == compare);

            car.Refuel(maxRefuel);
            Assert.That(car.FuelAmount == fuelCapacity);
        }

        [Test]
        public void Drive_ThrowException_WhenDataIsInvalid()
        {
            double invalidDistance = car.FuelCapacity;
            Assert.Throws<InvalidOperationException>(() => car.Drive(invalidDistance));
        }

        [Test]
        public void Drive_IsCorrect()
        {
            double maxRefuel = car.FuelCapacity;
            car.Refuel(maxRefuel);

            double distance = car.FuelConsumption;
            double fuelNeeded = (distance / 100) * car.FuelConsumption;
            double compare = car.FuelAmount - fuelNeeded;

            car.Drive(distance);
            Assert.That(car.FuelAmount == compare);
        }
    }
}