using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Aquariums.Tests
{
    using System;

    public class AquariumsTests
    {
        private Aquarium aquarium;
        private Fish fish;

        [SetUp]
        public void Setup()
        {
            aquarium = new Aquarium("Pz", 100);
            fish = new Fish("Boko");
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

            aquarium = new Aquarium(name, capacity);
            Assert.That(aquarium.Name == name);
            Assert.That(aquarium.Capacity == capacity);
        }

        [Test]
        public void Ctor_AquariumIsNotEmpty()
        {
            Assert.That(aquarium.Count, Is.Not.Null);
        }

        [Test]
        public void Count_IsZero()
        {
            string name = "name";
            string fishName = "fish";
            int capacity = 10;

            aquarium = new Aquarium(name, capacity);
            Assert.That(aquarium.Count == 0);
        }

        [Test]
        public void Count_IsWorking()
        {
            string name = "name";
            string fishName = "fish";
            int capacity = 10;

            aquarium = new Aquarium(name, capacity);

            for (int i = 0; i < capacity; i++)
            {
                aquarium.Add(new Fish(fishName + i));
            }

            Assert.That(aquarium.Count == capacity);
        }

        [Test]
        public void Add_ThrowException_DataIsFull()
        {
            string name = "name";
            string fishName = "fish";
            int capacity = 10;

            aquarium = new Aquarium(name, capacity);

            for (int i = 0; i < capacity; i++)
            {
                aquarium.Add(new Fish(fishName + i));
            }

            Assert.Throws<InvalidOperationException>(() => aquarium.Add(new Fish(fishName)));
        }

        [Test]
        public void Add_IsWorking()
        {
            int n = 5;

            string name = "name";
            string fishName = "fish";
            int capacity = 10;

            aquarium = new Aquarium(name, capacity);

            for (int i = 0; i < n; i++)
            {
                aquarium.Add(new Fish(fishName + i));
            }

            Assert.That(aquarium.Count == n);
        }

        [Test]
        public void Remove_ThrowException_DataIsFull()
        {
            string name = "name";
            string fishName = null;
            int capacity = 10;

            aquarium = new Aquarium(name, capacity);
            Assert.Throws<InvalidOperationException>(() => aquarium.RemoveFish(fishName));
        }

        [Test]
        public void Remove_IsWorking()
        {
            int n = 5;

            string name = "name";
            string fishName = "fish";
            int capacity = 10;

            aquarium = new Aquarium(name, capacity);

            for (int i = 0; i < n; i++)
            {
                aquarium.Add(new Fish(fishName + i));
            }

            aquarium.Add(new Fish(fishName));
            aquarium.RemoveFish(fishName);

            Assert.That(aquarium.Count == n);
        }

        [Test]
        public void Sell_ThrowException_DataIsFull()
        {
            string name = "name";
            string fishName = null;
            int capacity = 10;

            aquarium = new Aquarium(name, capacity);
            Assert.Throws<InvalidOperationException>(() => aquarium.SellFish(fishName));
        }

        [Test]
        public void Sell_IsWorking()
        {
            string name = "name";
            string fishName = "fish";
            int capacity = 10;

            var fish = new Fish(fishName);
            aquarium = new Aquarium(name, capacity);
            aquarium.Add(fish);
            aquarium.SellFish(fishName);

            Assert.That(fish.Available == false);
        }

        [Test]
        public void Report_IsWorking()
        {
            string name = "name";
            string fishName = "fish";
            int capacity = 10;

            aquarium = new Aquarium(name, capacity);
            var fishList = new List<Fish>();

            for (int i = 0; i < capacity; i++)
            {
                aquarium.Add(new Fish(fishName + i));
                fishList.Add(new Fish(fishName + i));
            }

            string fishNames = string.Join(", ", fishList.Select(f => f.Name));
            string report = $"Fish available at {name}: {fishNames}";

            Assert.That(aquarium.Report() == report);
        }
    }
}
