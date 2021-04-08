using System;
using System.Linq;
using FightingArena;
using NUnit.Framework;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;

        [SetUp]
        public void Setup()
        {
            arena = new Arena();
        }

        [Test]
        public void Ctor_ArenaIsNotEmpty()
        {
            Assert.That(arena.Warriors, Is.Not.Null);
        }

        [Test]
        public void Count_IsZero()
        {
            Assert.That(arena.Count == 0);
        }

        [Test]
        public void Enroll_ThrowException_WhenWarriorAlreadyExist()
        {
            var name = "name";
            arena.Enroll(new Warrior(name, 50, 100));

            Assert.Throws<InvalidOperationException>(() => arena.Enroll(new Warrior(name, 30, 50)));
        }

        [Test]
        public void Enroll_IsCorrect()
        {
            var name = "warrior";
            arena.Enroll(new Warrior(name, 50, 100));
            Assert.That(arena.Warriors.Count == 1);
            Assert.That(arena.Warriors.Any(w => w.Name == name));
        }

        [Test]
        [TestCase("", "defend")]
        [TestCase(null, "defend")]
        [TestCase("attack", "")]
        [TestCase("attack", null)]
        public void Fight_ThrowException_NameIsMissing(string attacker, string defender)
        {
            Assert.Throws<InvalidOperationException>(() => arena.Fight(attacker, defender));
        }

        [Test]
        public void Fight_ThrowException_AttackerIsMissing()
        {
            var attacker = "attacker";
            arena.Enroll(new Warrior(attacker, 50, 100));

            Assert.Throws<InvalidOperationException>(() => arena.Fight(attacker, "defender"));
        }

        [Test]
        public void Fight_ThrowException_DefenderIsMissing()
        {
            var defender = "defender";
            arena.Enroll(new Warrior(defender, 50, 100));

            Assert.Throws<InvalidOperationException>(() => arena.Fight("attacker", defender));
        }

        [Test]
        public void Attack_IsCorrect()
        {
            var attacker = new Warrior("warrior", 50, 100);
            var defender = new Warrior("defender", 50, 100);
            var compare = defender.HP - attacker.Damage;

            arena.Enroll(attacker);
            arena.Enroll(defender);

            arena.Fight(attacker.Name, defender.Name);
            Assert.That(defender.HP == compare);
        }
    }
}
