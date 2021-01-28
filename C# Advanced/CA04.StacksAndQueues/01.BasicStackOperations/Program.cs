using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];

            // calculation
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var collection = new Stack<int>(numbers);

            for (int i = 0; i < s; i++)
            {
                if (collection.Any() == true)
                {
                    collection.Pop();
                }
            }

            // output

            if (collection.Contains(x) == true)
            {
                Console.WriteLine("true");
            }

            else if (collection.Any() == true)
            {
                Console.WriteLine(collection.Min());
            }

            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
