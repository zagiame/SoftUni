using System;
using System.Text.RegularExpressions;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            // validation
            string pattern = @"(\*|@)(?<tag>([A-Z][a-z]{2,}))(\1): \[(?<tag1>[A-Za-z])\]\|\[(?<tag2>[A-Za-z])\]\|\[(?<tag3>[A-Za-z])\]\|";
            var validator = new Regex(pattern);

            // input
            int numberOfInputs = int.Parse(Console.ReadLine());

            // calculation

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();
                var message = validator.Match(input);
                int startIndex = input.IndexOf(message.ToString());
                int endIndex = startIndex + message.Length;

                if (message.Success == true && endIndex == input.Length)
                {
                    string name = message.Groups["tag"].Value;
                    char tag1 = char.Parse(message.Groups["tag1"].Value);
                    char tag2 = char.Parse(message.Groups["tag2"].Value);
                    char tag3 = char.Parse(message.Groups["tag3"].Value);

                    Console.WriteLine($"{name}: {(int)tag1} {(int)tag2} {(int)tag3}");
                }

                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
