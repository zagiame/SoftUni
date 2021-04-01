using System;
using System.Collections.Generic;

namespace Vehicles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // input
            var carInfo = Console.ReadLine().Split();
            var truckInfo = Console.ReadLine().Split();
            var busInfo = Console.ReadLine().Split();
            var n = int.Parse(Console.ReadLine());

            // calculation
            var car = CreateVehicle(carInfo);
            var truck = CreateVehicle(truckInfo);
            var bus = CreateVehicle(busInfo);

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var command = input[0];
                var type = input[1];
                var parameter = double.Parse(input[2]);

                try
                {
                    if (command == "Drive")
                    {

                        if (type == nameof(Car))
                        {
                            car.Drive(parameter);
                        }

                        else if (type == nameof(Truck))
                        {
                            truck.Drive(parameter);
                        }

                        else
                        {
                            bus.Drive(parameter);
                        }

                        Console.WriteLine($"{type} travelled {parameter} km");

                    }

                    else if (command == "DriveEmpty")
                    {
                        bus.DriveEmpty(parameter);

                        Console.WriteLine($"{type} travelled {parameter} km");
                    }

                    else if (command == "Refuel")
                    {
                        if (type == nameof(Car))
                        {
                            car.Refuel(parameter);
                        }

                        else
                        {
                            truck.Refuel(parameter);
                        }
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            // output
            Console.WriteLine($"Car: {car.Fuel:f2}");
            Console.WriteLine($"Truck: {truck.Fuel:f2}");
            Console.WriteLine($"Bus: {bus.Fuel:f2}");

        }

        private static Vehicle CreateVehicle(string[] data)
        {
            var type = data[0];
            var fuel = double.Parse(data[1]);
            var consumption = double.Parse(data[2]);
            var tankCapacity = double.Parse(data[3]);
            Vehicle toReturn = null;

            if (type == nameof(Car))
            {
                toReturn = new Car(fuel, consumption, tankCapacity);
            }

            else if (type == nameof(Truck))
            {
                toReturn = new Truck(fuel, consumption, tankCapacity);
            }

            else if (type == nameof(Bus))
            {
                toReturn = new Bus(fuel, consumption, tankCapacity);
            }

            return toReturn;
        }
    }
}
