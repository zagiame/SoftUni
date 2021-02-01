using System;
using System.Collections.Generic;


namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            // calculation
            var set = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (set.ContainsKey(input) == false)
                {
                    set.Add(input, 0);
                }

                set[input]++;
            }

            // output

            foreach (var item in set)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
