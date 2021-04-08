using NUnit.Framework;
using System;
using System.Linq;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault bank;

        [SetUp]
        public void Setup()
        {
            bank = new BankVault();
        }

        [Test]
        public void Add_ThrowException_CellDoesNotExist()
        {
            string wrongCell = "cell";
            Item item = null;

            Assert.Throws<ArgumentException>(() => bank.AddItem(wrongCell, item));
        }

        [Test]
        public void Add_ThrowException_ItemIsNotNull()
        {
            string cell = "A1";
            var item = new Item("owner", "id");

            bank.AddItem(cell, item);
            Assert.Throws<ArgumentException>(() => bank.AddItem(cell, item));
        }

        [Test]
        public void Add_ThrowException_IdAlreadyExist()
        {
            string cell = "A1";
            string secondCell = "A2";
            var item = new Item("owner", "id");

            bank.AddItem(cell, item);
            Assert.Throws<InvalidOperationException>(() => bank.AddItem(secondCell, item));
        }

        [Test]
        public void Add_IsCorrect()
        {
            string cell = "A1";
            var item = new Item("owner", "id");

            bank.AddItem(cell, item);
            Assert.That(bank.VaultCells[cell] == item);
            Assert.That(bank.VaultCells.Any(i => i.Value == item));
        }

        [Test]
        public void Remove_ThrowException_CellDoesNotExist()
        {
            string wrongCell = "cell";
            Item item = null;

            Assert.Throws<ArgumentException>(() => bank.RemoveItem(wrongCell, item));
        }

        [Test]
        public void Add_ThrowException_ItemIsNull()
        {
            string cell = "A1";
            var item = new Item("owner", "id");
            var itemToRemove = new Item("ownerToRemove", "idToRemove");

            bank.AddItem(cell, item);
            Assert.Throws<ArgumentException>(() => bank.AddItem(cell, itemToRemove));
        }

        [Test]
        public void Remove_IsCorrect()
        {
            string cell = "A1";
            var item = new Item("owner", "id");

            bank.AddItem(cell, item);
            bank.RemoveItem(cell, item);

            Assert.That(bank.VaultCells[cell] == null);
        }
    }
}