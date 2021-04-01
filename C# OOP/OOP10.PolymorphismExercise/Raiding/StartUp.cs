using System;
using System.Collections.Generic;

namespace Raiding
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // input
            var n = int.Parse(Console.ReadLine());

            // calculation
            var heroList = new List<BaseHero>();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var type = Console.ReadLine();

                BaseHero hero = CreateHero(type, name);

                if (hero == null)
                {
                    Console.WriteLine("Invalid hero!");
                }

                else
                {
                    heroList.Add(hero);
                }

            }

            var bossPower = int.Parse(Console.ReadLine());

            // output

            foreach (var item in heroList)
            {
                Console.WriteLine(item.CastAbility());
                bossPower -= item.Power;
            }

            if (bossPower > 0)
            {
                Console.WriteLine("Defeat...");
            }

            else
            {
                Console.WriteLine("Victory!");
            }
        }

        private static BaseHero CreateHero(string type, string name)
        {
            BaseHero hero = null;

            if (type == nameof(Druid))
            {
                hero = new Druid(name);
            }

            else if (type == nameof(Paladin))
            {
                hero = new Paladin(name);
            }

            else if (type == nameof(Rogue))
            {
                hero = new Rogue(name);
            }

            else if (type == nameof(Warrior))
            {
                hero = new Warrior(name);
            }

            return hero;
        }
    }
}
