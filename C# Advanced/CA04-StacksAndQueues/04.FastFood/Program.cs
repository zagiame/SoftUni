using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orderQuantity = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // calculation
            var orders = new Queue<int>(orderQuantity);
            Console.WriteLine(orders.Max());

            while (foodQuantity >= 0 && orders.Any() == true)
            {
                foodQuantity = foodQuantity - orders.Peek();

                if (foodQuantity >= 0)
                {
                    orders.Dequeue();
                }
            }

            // output
            if (orders.Any() == true)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }

            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
