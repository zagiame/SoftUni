using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string[] input = Console.ReadLine().Split();

            // calculation
            var legendary = new Dictionary<string, int>();
            var junk = new Dictionary<string, int>();
            bool isObtained = false;

            legendary["shards"] = 0;
            legendary["fragments"] = 0;
            legendary["motes"] = 0;

            while (isObtained != true)
            {

                for (int i = 0; i < input.Length; i += 2)
                {
                    int currentNumber = int.Parse(input[i]);
                    string currentMaterial = input[i + 1].ToLower();
                    bool isLegendary =
                        currentMaterial == "shards" ||
                        currentMaterial == "fragments" ||
                        currentMaterial == "motes";

                    if (isLegendary == true)
                    {
                        legendary[currentMaterial] = legendary[currentMaterial] + currentNumber;

                        if (legendary[currentMaterial] >= 250)
                        {
                            if (currentMaterial == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (currentMaterial == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else if (currentMaterial == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }

                            legendary[currentMaterial] = legendary[currentMaterial] - 250;
                            isObtained = true;
                            break;
                        }
                    }

                    else if (isLegendary == false)
                    {
                        if (junk.ContainsKey(currentMaterial) == false)
                        {
                            junk.Add(currentMaterial, 0);
                        }

                        junk[currentMaterial] = junk[currentMaterial] + currentNumber;
                    }

                }

                if (isObtained == true)
                {
                    break;
                }

                input = Console.ReadLine().Split();
            }

            // output

            foreach (var item in legendary
                .OrderByDescending(first => first.Value)
                .ThenBy(second => second.Key))
            {
                string currentMaterial = item.Key;
                int currentQuantity = item.Value;

                Console.WriteLine($"{currentMaterial}: {currentQuantity}");
            }

            foreach (var item in junk.OrderBy(first => first.Key))
            {
                string currentMaterial = item.Key;
                int currentQuantity = item.Value;

                Console.WriteLine($"{currentMaterial}: {currentQuantity}");
            }
        }
    }
}
