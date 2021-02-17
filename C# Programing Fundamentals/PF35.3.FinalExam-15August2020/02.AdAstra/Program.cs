using System;
using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            // validation
            string pattern = @"(\||#)(?<name>([A-Z a-z]+))(\1)(?<date>((0[1-9]|[1-2][0-9]|3[0-1])\/(0[1-9]|1[0-2])\/[0-9]{2}))(\1)(?<calories>[0-9]+)(\1)";
            var validator = new Regex(pattern);

            // input
            string input = Console.ReadLine();

            // calculation
            var food = validator.Matches(input);
            int totalNutrition = 0;

            foreach (Match item in food)
            {
                int currentNutrition = int.Parse(item.Groups["calories"].Value);
                totalNutrition = totalNutrition + currentNutrition;
            }

            int days = totalNutrition / 2000;

            // output
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match item in food)
            {
                string itemName = item.Groups["name"].Value;
                string date = item.Groups["date"].Value;
                string calories = item.Groups["calories"].Value;

                Console.WriteLine($"Item: {itemName}, Best before: {date}, Nutrition: {calories}");
            }
        }
    }
}

