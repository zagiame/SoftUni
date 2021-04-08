using System;
using ExtendedDatabase;
using NUnit.Framework;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase.ExtendedDatabase database;

        [SetUp]
        public void Setup()
        {
            database = new ExtendedDatabase.ExtendedDatabase();
        }

        [Test]
        public void Add_ThrowException_WhenCapacityIsExceeded()
        {
            long id = 16;
            string name = "Invalid Username";
            var person = new Person(id, name);

            for (int i = 0; i < 16; i++)
            {
                database.Add(new Person(i, $"Username: {i}"));
            }

            Assert.Throws<InvalidOperationException>(() => database.Add(person));
        }

        [Test]
        public void Add_ThrowException_WhenUserAlreadyExist()
        {
            long id = 1;
            string name = "ivan";
            var person = new Person(id, name);
            database.Add(person);

            Assert.Throws<InvalidOperationException>(() =>
                database.Add(new Person(id + 1, name)));
            Assert.Throws<InvalidOperationException>(() =>
                database.Add(new Person(id, name + 1)));
        }

        [Test]
        public void Add_IncreaseCount()
        {
            int n = 10;

            long id = 16;
            string name = "Invalid Username";
            var person = new Person(id, name);

            for (int i = 0; i < n; i++)
            {
                database.Add(new Person(i, $"Username: {i}"));
            }

            Assert.That(database.Count == n);
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
                database.Add(new Person(i, $"Username: {i}"));
            }

            database.Remove();
            Assert.That(database.Count == n - 1);
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void FindByName_ThrowException_WhenNameIsNotValid(string username)
        {
            Assert.Throws<ArgumentNullException>(() => database.FindByUsername(username));
        }

        [Test]
        public void FindByName_ThrowException_UserNameNotFound()
        {
            var user = "ivan";
            Assert.Throws<InvalidOperationException>(() => database.FindByUsername(user));
        }

        [Test]
        public void FindByName_ReturnsExpectedUser()
        {
            long id = 16;
            string name = "ivan";
            var person = new Person(id, name);
            database.Add(person);

            var toCompare = database.FindByUsername(person.UserName);
            Assert.That(person, Is.EqualTo(toCompare));
        }

        [Test]
        [TestCase(-10)]
        [TestCase(-25)]
        public void FindByID_ThrowException_WhenIDIsNotValid(long id)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(id));
        }

        [Test]
        public void FindByID_ThrowException_UserIDNotFound()
        {
            var id = 10;
            Assert.Throws<InvalidOperationException>(() => database.FindById(id));
        }

        [Test]
        public void FindByID_ReturnsExpectedUser()
        {
            long id = 16;
            string name = "ivan";
            var person = new Person(id, name);
            database.Add(person);

            var toCompare = database.FindById(person.Id);
            Assert.That(person, Is.EqualTo(toCompare));
        }

        [Test]
        public void Ctor_ThrowException_WhenCapacityExceeded()
        {
            var massive = new Person[17];

            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = new Person(i, $"Username: {i}");
            }

            Assert.Throws<ArgumentException>(() =>
                database = new ExtendedDatabase.ExtendedDatabase(massive));
        }

        [Test]
        public void Ctor_AddToDatabase()
        {
            var massive = new Person[5];

            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = new Person(i, $"Username: {i}");
            }

            database = new ExtendedDatabase.ExtendedDatabase(massive);
            Assert.That(database.Count == massive.Length);
        }
    }
}