using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // calculation
            List<int> result = new List<int>();
            double length = input.Length;
            double averageSum = input.Sum() / length;

            for (int i = 0; i < length; i++)
            {
                if (input[i] > averageSum)
                {
                    result.Add(input[i]);
                }
            }

            result.Sort();
            result.Reverse();

            if (result.Count > 5)
            {
                int removeCount = result.Count - 5;
                result.RemoveRange(5, removeCount);
            }

            // output
            if (result.Count != 0)
            {
                Console.WriteLine(string.Join(' ', result));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
