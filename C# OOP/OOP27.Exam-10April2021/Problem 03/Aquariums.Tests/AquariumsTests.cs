using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Aquariums.Tests
{
    using System;

    public class AquariumsTests
    {
        private Aquarium data;

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Ctor_ThrowException_NameIsNull()
        {
            string nameNull = null;
            string nameWhite = "";
            string nameEmpty = string.Empty;

            int capacity = 10;

            Assert.Throws<ArgumentNullException>(() => new Aquarium(nameNull, capacity));
            Assert.Throws<ArgumentNullException>(() => new Aquarium(nameWhite, capacity));
            Assert.Throws<ArgumentNullException>(() => new Aquarium(nameEmpty, capacity));
        }

        [Test]
        public void Ctor_ThrowException_CapacityIsInvalid()
        {
            string name = "name";
            int capacityNegative = -10;

            Assert.Throws<ArgumentException>(() => new Aquarium(name, capacityNegative));
        }

        [Test]
        public void Ctor_SetValue()
        {
            string name = "name";
            int capacity = 10;

            data = new Aquarium(name, capacity);
            Assert.That(data.Name == name);
            Assert.That(data.Capacity == capacity);
        }

        [Test]
        public void Ctor_AquariumIsNotEmpty()
        {
            var fishList = new List<Fish>();
            Assert.That(fishList, Is.Not.Null);
        }

        [Test]
        public void Count_IsZero()
        {
            string name = "name";
            string fishName = "fish";
            int capacity = 10;

            data = new Aquarium(name, capacity);
            Assert.That(data.Count == 0);
        }

        [Test]
        public void Count_IsWorking()
        {
            string name = "name";
            string fishName = "fish";
            int capacity = 10;

            data = new Aquarium(name, capacity);

            for (int i = 0; i < capacity; i++)
            {
                data.Add(new Fish(fishName + i));
            }

            Assert.That(data.Count == capacity);
        }

        [Test]
        public void Add_ThrowException_DataIsFull()
        {
            string name = "name";
            string fishName = "fish";
            int capacity = 10;

            data = new Aquarium(name, capacity);

            for (int i = 0; i < capacity; i++)
            {
                data.Add(new Fish(fishName + i));
            }

            Assert.Throws<InvalidOperationException>(() => data.Add(new Fish(fishName)));
        }

        [Test]
        public void Add_IsWorking()
        {
            int n = 5;

            string name = "name";
            string fishName = "fish";
            int capacity = 10;

            data = new Aquarium(name, capacity);

            for (int i = 0; i < n; i++)
            {
                data.Add(new Fish(fishName + i));
            }

            Assert.That(data.Count == n);
        }

        [Test]
        public void Remove_ThrowException_DataIsFull()
        {
            string name = "name";
            string fishName = null;
            int capacity = 10;

            data = new Aquarium(name, capacity);
            Assert.Throws<InvalidOperationException>(() => data.RemoveFish(fishName));
        }

        [Test]
        public void Remove_IsWorking()
        {
            int n = 5;

            string name = "name";
            string fishName = "fish";
            int capacity = 10;

            data = new Aquarium(name, capacity);

            for (int i = 0; i < n; i++)
            {
                data.Add(new Fish(fishName + i));
            }

            data.Add(new Fish(fishName));
            data.RemoveFish(fishName);

            Assert.That(data.Count == n);
        }

        [Test]
        public void Sell_ThrowException_DataIsFull()
        {
            string name = "name";
            string fishName = null;
            int capacity = 10;

            data = new Aquarium(name, capacity);
            Assert.Throws<InvalidOperationException>(() => data.SellFish(fishName));
        }

        [Test]
        public void Sell_IsWorking()
        {
            string name = "name";
            string fishName = "fish";
            int capacity = 10;

            var fish = new Fish(fishName);
            data = new Aquarium(name, capacity);
            data.Add(fish);
            data.SellFish(fishName);

            Assert.That(fish.Available == false);
        }

        [Test]
        public void Report_IsWorking()
        {
            string name = "name";
            string fishName = "fish";
            int capacity = 10;

            data = new Aquarium(name, capacity);
            var fishList = new List<Fish>();

            for (int i = 0; i < capacity; i++)
            {
                data.Add(new Fish(fishName + i));
                fishList.Add(new Fish(fishName + i));
            }

            string fishNames = string.Join(", ", fishList.Select(f => f.Name));
            string report = $"Fish available at {name}: {fishNames}";

            Assert.That(data.Report() == report);
        }
    }
}
