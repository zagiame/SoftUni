using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            List<string> input = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            // calculation
            input.Reverse();
            List<string> result = new List<string>();

            foreach (string currentItem in input)
            {
                string[] numbers = currentItem.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                             .ToArray();

                foreach (string numbersToAdd in numbers)
                {
                    result.Add(numbersToAdd);
                }
            }

            // output
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
