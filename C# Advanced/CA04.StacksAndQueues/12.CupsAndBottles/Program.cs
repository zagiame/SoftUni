using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            var cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            // calculation
            int wastedWater = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int currentCup = cups.Dequeue();
                int currentBottle = bottles.Pop();

                while (currentCup > 0)
                {
                    int sum = currentBottle - currentCup;

                    if (sum >= 0)
                    {
                        wastedWater = wastedWater + sum;
                        currentCup = 0;
                    }

                    else
                    {
                        currentCup = currentCup - currentBottle;
                        currentBottle = bottles.Pop();
                    }

                }
            }

            // output

            if (cups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }

            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");

        }
    }
}
