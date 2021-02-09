using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            // calculation
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carData = Console.ReadLine().Split();
                string model = carData[0];
                double fuelAmount = double.Parse(carData[1]);
                double fuelConsumptionFor1km = double.Parse(carData[2]);

                Car currentCar = new Car
                {
                    Model = model,
                    FuelAmount = fuelAmount,
                    FuelConsumptionPerKilometer = fuelConsumptionFor1km
                };

                cars.Add(currentCar);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                string model = command[1];
                double distance = double.Parse(command[2]);

                Car car = cars.FirstOrDefault(c => c.Model == model);
                bool isDriven = car.Drive(distance);

                if (isDriven == false)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            // output
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");
            }
        }
    }
}
