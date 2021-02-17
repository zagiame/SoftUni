using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.HeroesCodeLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int maxParty = int.Parse(Console.ReadLine());

            // calculation
            var partyMembers = new List<Hero>();
            int hpMax = 100;
            int mpMax = 200;

            for (int i = 0; i < maxParty; i++)
            {
                string[] command = Console.ReadLine().Split();

                string heroName = command[0];
                int hp = int.Parse(command[1]);
                int mana = int.Parse(command[2]);

                Hero player = new Hero
                {
                    name = heroName,
                    health = hp,
                    mana = mana
                };

                partyMembers.Add(player);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(" - ");
                string action = command[0];
                string heroName = command[1];

                Hero player = partyMembers.FirstOrDefault(first => first.name == heroName);

                if (action == "CastSpell")
                {
                    int manaNeeded = int.Parse(command[2]);
                    string spellName = command[3];

                    if (player.mana >= manaNeeded)
                    {
                        player.mana = player.mana - manaNeeded;

                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {player.mana} MP!");
                    }

                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }

                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(command[2]);
                    string attacker = command[3];

                    player.health = player.health - damage;

                    if (player.health > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {player.health} HP left!");
                    }

                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        partyMembers.Remove(player);
                    }
                }


                else if (action == "Recharge")
                {
                    int recharge = int.Parse(command[2]);
                    int beforeMana = player.mana;
                    player.mana = player.mana + recharge;

                    if (player.mana > mpMax)
                    {
                        player.mana = mpMax;
                    }

                    int afterMana = player.mana;
                    int totalMana = afterMana - beforeMana;

                    Console.WriteLine($"{heroName} recharged for {totalMana} MP!");
                }


                else if (action == "Heal")
                {
                    int heal = int.Parse(command[2]);
                    int beforeHeal = player.health;
                    player.health = player.health + heal;

                    if (player.health > hpMax)
                    {
                        player.health = hpMax;
                    }

                    int afterHeal = player.health;
                    int totalHeal = afterHeal - beforeHeal;


                    Console.WriteLine($"{heroName} healed for {totalHeal} HP!");
                }

            }

            // output

            foreach (var item in partyMembers.OrderByDescending(first => first.health).ThenBy(second => second.name))
            {
                Console.WriteLine(item);
            }

        }

        class Hero
        {
            public string name { get; set; }
            public int health { get; set; }
            public int mana { get; set; }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(name);
                sb.AppendLine($"  HP: {health}");
                sb.AppendLine($"  MP: {mana}");

                return sb.ToString().TrimEnd();
            }
        }
    }
}
