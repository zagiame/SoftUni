using System;
using FightingArena;
using NUnit.Framework;

namespace Tests
{
    public class WarriorTests
    {
        private Warrior warrior;
        private string name = "name";
        private int damage = 10;
        private int hp = 100;

        [SetUp]
        public void Setup()
        {
            warrior = new Warrior(name, damage, hp);
        }

        [Test]
        [TestCase("", 10, 100)]
        [TestCase(null, 10, 100)]
        [TestCase("name", 0, 100)]
        [TestCase("name", -10, 100)]
        [TestCase("name", 10, -100)]
        public void Ctor_ThrowException_WhenDataIsInvalid(string name, int damage, int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, damage, hp));
        }

        [Test]
        public void Ctor_SetValue()
        {
            Assert.That(warrior.Name == name);
            Assert.That(warrior.Damage == damage);
            Assert.That(warrior.HP == hp);
        }

        [Test]
        [TestCase(15)]
        [TestCase(30)]
        public void Attack_ThrowException_WhenAttackerHasLowHP(int lowHP)
        {
            var attacker = new Warrior("Attacker", 50, lowHP);
            var defender = warrior;

            Assert.Throws<InvalidOperationException>(() => attacker.Attack(defender));
        }

        [Test]
        [TestCase(15)]
        [TestCase(30)]
        public void Attack_ThrowException_WhenDefenderHasLowHP(int lowHP)
        {
            var attacker = warrior;
            var defender = new Warrior("Defender", 50, lowHP);

            Assert.Throws<InvalidOperationException>(() => defender.Attack(attacker));
        }

        [Test]
        public void Attack_ThrowException_WhenDefenderKillsAttacker()
        {
            var attacker = warrior;
            var defender = new Warrior("Defender", warrior.HP + 1, warrior.HP);

            Assert.Throws<InvalidOperationException>(() => attacker.Attack(defender));
        }

        [Test]
        public void Attack_IsCorrect()
        {
            var attacker = warrior;
            var defender = new Warrior("Defender", warrior.HP / 2, warrior.HP);
            double compare = defender.HP - attacker.Damage;

            attacker.Attack(defender);
            Assert.That(defender.HP == compare);
        }

        [Test]
        public void Attack_HPisZero()
        {
            var attacker = new Warrior("Attacker", warrior.HP * 2, warrior.HP);
            var defender = warrior;
            double compare = 0;

            attacker.Attack(defender);
            Assert.That(defender.HP == 0);
        }
    }
}