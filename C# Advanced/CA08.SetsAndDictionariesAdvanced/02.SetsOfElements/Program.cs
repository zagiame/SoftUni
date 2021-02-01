using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];

            // calculation
            var setOne = new List<string>();
            var setTwo = new List<string>();
            var set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                setOne.Add(Console.ReadLine());
            }

            for (int i = 0; i < m; i++)
            {
                setTwo.Add(Console.ReadLine());
            }

            // output

            foreach (var item in setOne)
            {
                if (setTwo.Contains(item))
                {
                    set.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", set));
        }
    }
}
