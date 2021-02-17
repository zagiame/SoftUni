using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Initialize the repository
            Parking parking = new Parking("Underground parking garage", 5);

            // Initialize entity
            Car volvo = new Car("Volvo", "XC70", 2010);

            // Print Car
            Console.WriteLine(volvo); // Volvo XC70 (2010)

            // Add Car
            parking.Add(volvo);

            // Remove Car
            Console.WriteLine(parking.Remove("Volvo", "XC90")); // False
            Console.WriteLine(parking.Remove("Volvo", "XC70")); // True

            Car peugeot = new Car("Peugeot", "307", 2011);
            Car audi = new Car("Audi", "S4", 2005);

            parking.Add(peugeot);
            parking.Add(audi);

            // Get Latest Car
            Car latestCar = parking.GetLatestCar();
            Console.WriteLine(latestCar); // Peugeot 307 (2011)

            // Get Car
            Car audiS4 = parking.GetCar("Audi", "S4");
            Console.WriteLine(audiS4); // Audi S4 (2005)

            // Count
            Console.WriteLine(parking.Count); // 2

            // Get Statistics
            Console.WriteLine(parking.GetStatistics());
            // The cars are parked in Underground parking garage:
            // Peugeot 307(2011)
            // Audi S4(2005)
        }

        class Car
        {
            // constructor
            public Car(string manufacturer, string model, int year)
            {
                Manufacturer = manufacturer;
                Model = model;
                Year = year;
            }

            // property
            public string Manufacturer { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

            // method
            public override string ToString()
            {
                return $"{Manufacturer} {Model} ({Year})";
            }
        }

        class Parking
        {
            // field
            private List<Car> data;

            // constructor
            public Parking(string type, int capacity)
            {
                data = new List<Car>();
                Type = type;
                Capacity = capacity;
            }

            // property
            public string Type { get; set; }
            public int Capacity { get; set; }
            public int Count { get => data.Count(); }

            // method
            public void Add(Car car)
            {
                if (data.Count < Capacity)
                {
                    data.Add(car);
                }
            }

            public bool Remove(string manufacturer, string model)
            {
                return data.Remove(data.FirstOrDefault(car =>
                car.Manufacturer == manufacturer &&
                car.Model == model));
            }

            public Car GetLatestCar()
            {
                Car current = data.OrderByDescending(first => first.Year).FirstOrDefault();

                return current;
            }

            public Car GetCar(string manufacturer, string model)
            {
                Car getCurrent = data.FirstOrDefault(car =>
                car.Manufacturer == manufacturer &&
                car.Model == model);

                return getCurrent;
            }

            public string GetStatistics()
            {
                StringBuilder text = new StringBuilder();

                text.AppendLine($"The cars are parked in {Type}:");

                foreach (var item in data)
                {
                    text.AppendLine(item.ToString());
                }

                return text.ToString();
            }
        }
    }
}
