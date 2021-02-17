using System;
using System.Collections.Generic;

namespace _01.CountCharsString
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            char[] input = Console.ReadLine().ToCharArray();

            // calculation
            var dir = new Dictionary<char, int>();

            foreach (var item in input)
            {
                if (item != ' ')
                {
                    if (dir.ContainsKey(item) != true)
                    {
                        dir.Add(item, 0);
                    }

                    dir[item]++;
                }
            }

            // ouput
            foreach (var item in dir)
            {
                char currentKey = item.Key;
                int currentValue = item.Value;

                Console.WriteLine($"{currentKey} -> {currentValue}");
            }
        }
    }
}
