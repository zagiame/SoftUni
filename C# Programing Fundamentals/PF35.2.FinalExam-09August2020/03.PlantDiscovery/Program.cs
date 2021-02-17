using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int numberOfPlants = int.Parse(Console.ReadLine());

            // calculation
            var plantsCollection = new Dictionary<string, int>();
            var ratingCollection = new Dictionary<string, List<int>>();

            for (int i = 0; i < numberOfPlants; i++)
            {
                string[] current = Console.ReadLine().Split("<->");
                string plant = current[0];
                int rarity = int.Parse(current[1]);

                if (plantsCollection.ContainsKey(plant) == false)
                {
                    plantsCollection.Add(plant, 0);
                    ratingCollection.Add(plant, new List<int>());
                }

                plantsCollection[plant] = rarity;
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Exhibition")
            {
                string[] commnad = input.Split(": ");
                string action = commnad[0];
                string[] operators = commnad[1].Split(" - ");
                string plant = operators[0];

                if (action == "Rate")
                {
                    int rating = int.Parse(operators[1]);

                    if (plantsCollection.ContainsKey(plant) == true)
                    {
                        ratingCollection[plant].Add(rating);
                    }

                    else
                    {
                        Console.WriteLine("error");
                    }

                }

                else if (action == "Update")
                {
                    int newRarity = int.Parse(operators[1]);

                    if (plantsCollection.ContainsKey(plant) == true)
                    {
                        plantsCollection[plant] = newRarity;
                    }

                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                else if (action == "Reset")
                {

                    if (plantsCollection.ContainsKey(plant) == true)
                    {
                        ratingCollection[plant].RemoveRange(0, ratingCollection[plant].Count);
                    }

                    else
                    {
                        Console.WriteLine("error");
                    }

                }
            }

            // output

            Console.WriteLine("Plants for the exhibition:");

            foreach (var item in plantsCollection.OrderByDescending(first => first.Value))
            {
                double averageRating = 0;
                double sum = ratingCollection[item.Key].Sum();
                int count = ratingCollection[item.Key].Count;

                if (count > 0)
                {
                    averageRating = sum / count;
                }

                Console.WriteLine($"- {item.Key}; Rarity: {item.Value}; Rating: {averageRating:f2}");
            }
        }
    }
}
