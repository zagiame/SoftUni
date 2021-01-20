using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int num = int.Parse(Console.ReadLine());

            // calculation
            var collection = new Stack<int>();

            for (int i = 0; i < num; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int action = input[0];

                if (action == 1)
                {
                    collection.Push(input[1]);
                }

                if (collection.Any() == true)
                {
                    if (action == 2)
                    {
                        collection.Pop();
                    }

                    else if (action == 3)
                    {
                        Console.WriteLine(collection.Max());
                    }

                    else if (action == 4)
                    {
                        Console.WriteLine(collection.Min());
                    }

                }

            }

            // output
            Console.WriteLine(string.Join(", ", collection));
        }
    }
}
