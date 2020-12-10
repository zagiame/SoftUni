using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = string.Empty;

            // calculation
            var city = new Dictionary<string, List<int>>();

            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] commnad = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string townName = commnad[0];
                int population = int.Parse(commnad[1]);
                int gold = int.Parse(commnad[2]);


                if (city.ContainsKey(townName) == false)
                {
                    city.Add(townName, new List<int>());
                    city[townName].Add(0);
                    city[townName].Add(0);
                }

                city[townName][0] = city[townName][0] + population;
                city[townName][1] = city[townName][1] + gold;

            }

            // action

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commnad = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string action = commnad[0];
                string townName = commnad[1];
                int people;
                int gold;

                if (action == "Plunder")
                {
                    people = int.Parse(commnad[2]);
                    gold = int.Parse(commnad[3]);

                    Console.WriteLine($"{townName} plundered! {gold} gold stolen, {people} citizens killed.");
                    city[townName][0] = city[townName][0] - people;
                    city[townName][1] = city[townName][1] - gold;

                    if (city[townName][0] <= 0 || city[townName][1] <= 0)
                    {
                        city.Remove(townName);
                        Console.WriteLine($"{townName} has been wiped off the map!");
                    }
                }

                else
                {
                    gold = int.Parse(commnad[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }

                    city[townName][1] = city[townName][1] + gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {townName} now has {city[townName][1]} gold.");

                }

            }

            // output

            if (city.Count > 0)
            {
                var cityLeft = city.OrderByDescending(first => first.Value[1]).ThenBy(second => second.Key);

                Console.WriteLine($"Ahoy, Captain! There are {city.Count} wealthy settlements to go to:");

                foreach (var item in cityLeft)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }

            }

            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
