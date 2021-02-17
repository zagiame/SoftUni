using System;
using System.Linq;

namespace _03.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] house = Console.ReadLine().Split('@').Select(int.Parse).ToArray();
            string input = string.Empty;

            // calculation
            int loveCount = 0;
            int failedCount = 0;
            int lastPositionIndex = 0;

            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] command = input.Split();
                int jumpRange = int.Parse(command[1]);
                int nextPositionIndex = lastPositionIndex + jumpRange;
                lastPositionIndex = nextPositionIndex;

                if (nextPositionIndex >= house.Length)
                {
                    nextPositionIndex = 0;
                    lastPositionIndex = 0;
                }

                if (house[nextPositionIndex] <= 0)
                {
                    Console.WriteLine($"Place {nextPositionIndex} already had Valentine's day.");
                    continue;
                }

                house[nextPositionIndex] = house[nextPositionIndex] - 2;

                if (house[nextPositionIndex] <= 0)
                {
                    Console.WriteLine($"Place {nextPositionIndex} has Valentine's day.");
                    loveCount++;
                }
            }

            // output
            failedCount = house.Count() - loveCount;

            Console.WriteLine($"Cupid's last position was {lastPositionIndex}.");

            if (failedCount == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failedCount} places.");
            }
        }
    }
}
