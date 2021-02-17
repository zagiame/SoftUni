using System;
using System.Collections.Generic;

namespace _02.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = string.Empty;

            // calculation
            var materiials = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "stop")
            {
                string resource = input;
                int quantity = int.Parse(Console.ReadLine());

                if (materiials.ContainsKey(resource) != true)
                {
                    materiials.Add(resource, 0);
                }

                materiials[resource] = materiials[resource] + quantity;
            }

            // output

            foreach (var item in materiials)
            {
                string currentKey = item.Key;
                int currentValue = item.Value;

                Console.WriteLine($"{currentKey} -> {currentValue}");
            }
        }
    }
}
