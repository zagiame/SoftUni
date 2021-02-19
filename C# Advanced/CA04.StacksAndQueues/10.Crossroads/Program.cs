using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int greenLightLength = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            // calculation
            string input = string.Empty;
            var carWaiting = new Queue<string>();
            int totalCarsPassed = 0;

            while ((input = Console.ReadLine()) != "END")
            {
                if (input != "green")
                {
                    carWaiting.Enqueue(input);
                    continue;
                }

                int currentGreenLight = greenLightLength;

                string passingCar = null;
                while (currentGreenLight > 0 && carWaiting.Any())
                {
                    passingCar = carWaiting.Dequeue();
                    currentGreenLight -= passingCar.Length;
                    totalCarsPassed++;
                }

                int freeWindowLeft = freeWindow + currentGreenLight;
                if (freeWindowLeft < 0)
                {
                    int symbolsThatDidntPass = Math.Abs(freeWindowLeft);
                    int indexOfHitSymbol = passingCar.Length - symbolsThatDidntPass;
                    char symbolHit = passingCar[indexOfHitSymbol];
                    Crash(passingCar, symbolHit);
                }
            }

            // output

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");

        }

        private static void Crash(string car, char symbolHit)
        {
            Console.WriteLine("A crash happened!");
            Console.WriteLine($"{car} was hit at {symbolHit}.");
            Environment.Exit(0);
        }
    }
}
