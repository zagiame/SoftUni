using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int carsToAdd = int.Parse(Console.ReadLine());

            // calculation
            var mileageList = new Dictionary<string, int>();
            var fuelList = new Dictionary<string, int>();
            string input = string.Empty;

            int maxDistance = 100000;
            int minDistance = 10000;
            int maxFuel = 75;

            for (int i = 0; i < carsToAdd; i++)
            {
                string[] carInput = Console.ReadLine().Split('|');
                string car = carInput[0];
                int mileage = int.Parse(carInput[1]);
                int fuel = int.Parse(carInput[2]);

                mileageList.Add(car, mileage);
                fuelList.Add(car, fuel);

            }

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] command = input.Split(" : ");
                string action = command[0];
                string car = command[1];

                if (action == "Drive")
                {
                    int distance = int.Parse(command[2]);
                    int fuel = int.Parse(command[3]);

                    if (fuelList[car] < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }

                    else
                    {
                        mileageList[car] = mileageList[car] + distance;
                        fuelList[car] = fuelList[car] - fuel;

                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }

                    if (mileageList[car] >= maxDistance)
                    {
                        mileageList.Remove(car);
                        fuelList.Remove(car);

                        Console.WriteLine($"Time to sell the {car}!");
                    }

                }

                else if (action == "Refuel")
                {
                    int fuel = int.Parse(command[2]);

                    if (fuelList[car] + fuel > maxFuel)
                    {
                        fuel = maxFuel - fuelList[car];
                    }

                    fuelList[car] = fuelList[car] + fuel;

                    Console.WriteLine($"{car} refueled with {fuel} liters");

                }

                else if (action == "Revert")
                {
                    int kilometers = int.Parse(command[2]);
                    mileageList[car] = mileageList[car] - kilometers;

                    if (mileageList[car] < minDistance)
                    {
                        mileageList[car] = minDistance;
                    }

                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                }
            }

            // output

            foreach (var item in mileageList.OrderByDescending(first => first.Value).ThenBy(second => second.Key))
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value} kms, Fuel in the tank: {fuelList[item.Key]} lt.");
            }
        }
    }
}
