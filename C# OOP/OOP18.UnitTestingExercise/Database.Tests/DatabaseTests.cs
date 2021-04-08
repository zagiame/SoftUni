using System;
using System.Linq;
using NUnit.Framework;

namespace Tests
{
    public class DatabaseTests
    {
        private Database.Database database;

        [SetUp]
        public void Setup()
        {
            database = new Database.Database();
        }

        [Test]
        public void Add_ThrowException_WhenCapacityIsExceeded()
        {

            for (int i = 0; i < 16; i++)
            {
                database.Add(i);
            }

            Assert.Throws<InvalidOperationException>(() => database.Add(17));
        }

        [Test]
        public void Add_IncreaseCount()
        {
            int n = 10;

            for (int i = 0; i < n; i++)
            {
                database.Add(i);
            }

            Assert.That(database.Count == n);
        }

        [Test]
        public void Add_AddsElementToDatabase()
        {
            int element = 10;
            database.Add(element);
            var fetch = database.Fetch();

            Assert.That(fetch.Contains(element));
        }

        [Test]
        public void Remove_ThrowException_WhenDatabaseIsEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void Remove_DecreaseCount()
        {
            int n = 10;

            for (int i = 0; i < n; i++)
            {
                database.Add(i);
            }

            database.Remove();
            Assert.That(database.Count == n - 1);
        }

        [Test]
        public void Remove_RemoveElementToDatabase()
        {
            int element = 10;
            database.Add(element);
            database.Remove();
            var fetch = database.Fetch();

            Assert.IsFalse(fetch.Contains(element));
        }

        [Test]
        public void Fetch_ReturnsCopyInsteadOfReference()
        {
            int element = 10;
            database.Add(element);
            database.Add(element);
            database.Add(element);

            var firstCopy = database.Fetch();
            database.Add(element);
            database.Add(element);

            var secondCopy = database.Fetch();
            Assert.That(firstCopy != secondCopy);
        }

        [Test]
        public void Count_ReturnZeroWhenEmpty()
        {
            Assert.That(database.Count == 0);
        }

        [Test]
        public void Ctor_ThrowException_WhenCapacityExceeded()
        {
            var massive = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };

            Assert.Throws<InvalidOperationException>(() =>
                database = new Database.Database(massive));
        }

        [Test]
        public void Ctor_AddsToDatabase()
        {
            var massive = new[] { 1, 2, 3 };
            database = new Database.Database(massive);

            Assert.That(database.Count == massive.Length);
            Assert.That(database.Fetch(), Is.EquivalentTo(massive));
        }
    }
}
