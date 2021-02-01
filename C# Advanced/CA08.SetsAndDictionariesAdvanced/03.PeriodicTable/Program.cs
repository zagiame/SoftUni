using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            // calculation
            var set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                foreach (var item in input)
                {
                    set.Add(item);
                }
            }

            // output

            foreach (var item in set.OrderBy(first => first))
            {
                Console.Write(item + " ");
            }
        }
    }
}
