using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] allClothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            // calculation
            var clothes = new Stack<int>(allClothes);
            int currentCapacity = capacity;
            int racks = 1;

            while (clothes.Any() == true)
            {
                currentCapacity = currentCapacity - clothes.Peek();

                if (currentCapacity < 0)
                {
                    racks++;
                    currentCapacity = capacity;
                }

                else
                {
                    clothes.Pop();
                }
            }

            // output
            Console.WriteLine(racks);
        }
    }
}
