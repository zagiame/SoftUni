using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            // calculation
            var set = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(',');

                if (set.ContainsKey(color) == false)
                {
                    set.Add(color, new Dictionary<string, int>());
                }

                foreach (var item in clothes)
                {

                    if (set[color].ContainsKey(item) == false)
                    {
                        set[color].Add(item, 0);
                    }

                    set[color][item]++;
                }
            }

            // output
            string[] lookingFor = Console.ReadLine().Split();

            foreach (var item in set)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var pair in item.Value)
                {
                    if (item.Key == lookingFor[0] && pair.Key == lookingFor[1])
                    {
                        Console.WriteLine($"* {pair.Key} - {pair.Value} (found!)");
                    }

                    else
                    {
                        Console.WriteLine($"* {pair.Key} - {pair.Value}");
                    }
                }
            }

        }
    }
}
