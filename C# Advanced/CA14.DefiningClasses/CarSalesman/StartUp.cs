using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = int.Parse(input[1]);
                string displacement = "n/a";
                string efficiency = "n/a";

                if (input.Length == 3)
                {
                    string thirdParam = input[2];

                    if (Char.IsDigit(thirdParam, 0))
                    {
                        displacement = thirdParam;
                    }
                    else
                    {
                        efficiency = thirdParam;
                    }
                }

                else if (input.Length == 4)
                {
                    displacement = input[2];
                    efficiency = input[3];

                }

                var currentEngine = new Engine(model, power, displacement, efficiency);
                engines.Add(currentEngine);

            }

            int m = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                var engine = engines.Where(x => x.Model == input[1]).FirstOrDefault();
                string weight = "n/a";
                string color = "n/a";


                if (input.Length == 3)
                {
                    string thirdParam = input[2];

                    if (Char.IsDigit(thirdParam, 0))
                    {
                        weight = thirdParam;
                    }
                    else
                    {
                        color = thirdParam;
                    }
                }

                else if (input.Length == 4)
                {
                    weight = input[2];
                    color = input[3];
                }

                var currentCar = new Car(model, engine, weight, color);
                cars.Add(currentCar);
            }

            // output

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model}:");
                Console.WriteLine($"  {item.Engine.Model}:");

                Console.WriteLine($"    Power: {item.Engine.Power}");
                Console.WriteLine($"    Displacement: {item.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {item.Engine.Efficiency}");

                Console.WriteLine($"  Weight: {item.Weight}");
                Console.WriteLine($"  Color: {item.Color}");
            }

        }

        public class Car
        {
            public string Model { get; set; }

            public Engine Engine { get; set; }

            public string Weight { get; set; }

            public string Color { get; set; }


            public Car(string model, Engine engine, string weight, string color)
            {
                this.Model = model;
                this.Engine = engine;
                this.Weight = weight;
                this.Color = color;
            }
        }

        public class Engine
        {
            public string Model { get; set; }

            public int Power { get; set; }

            public string Displacement { get; set; }

            public string Efficiency { get; set; }

            public Engine(string model, int power, string displacement, string efficiency)
            {
                this.Model = model;
                this.Power = power;
                this.Displacement = displacement;
                this.Efficiency = efficiency;
            }

        }

    }
}
