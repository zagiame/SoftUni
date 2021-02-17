using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            // validation
            string pattern = @"(=|\/)([A-Z][A-Za-z]{2,})(\1)";
            var validator = new Regex(pattern);

            // input
            string input = Console.ReadLine();

            // calculation
            var destination = validator.Matches(input);
            int travelPoints = 0;
            var valid = new List<string>();

            foreach (Match item in destination)
            {
                travelPoints = travelPoints + item.Groups[2].Value.Length;
                valid.Add(item.Groups[2].Value);
            }

            // output
            Console.WriteLine($"Destinations: {string.Join(", ", valid)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
