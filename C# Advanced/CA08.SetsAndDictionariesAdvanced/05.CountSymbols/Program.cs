using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = Console.ReadLine();

            // calculation
            var set = new SortedDictionary<char, int>();

            foreach (var item in input)
            {
                if (set.ContainsKey(item) == false)
                {
                    set.Add(item, 0);
                }

                set[item]++;
            }

            // output

            foreach (var item in set)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
