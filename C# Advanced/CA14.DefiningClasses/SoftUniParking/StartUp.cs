using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var car = new Car("Skoda", "Fabia", 65, "CC1856BG");
            var car2 = new Car("Audi", "A3", 110, "EB8787MN");

            Console.WriteLine(car.ToString());
            //Make: Skoda
            //Model: Fabia
            //HorsePower: 65
            //RegistrationNumber: CC1856BG

            var parking = new Parking(5);
            Console.WriteLine(parking.AddCar(car));
            //Successfully added new car Skoda CC1856BG

            Console.WriteLine(parking.AddCar(car));
            //Car with that registration number, already exists!

            Console.WriteLine(parking.AddCar(car2));
            //Successfully added new car Audi EB8787MN

            Console.WriteLine(parking.GetCar("EB8787MN").ToString());
            //Make: Audi
            //Model: A3
            //HorsePower: 110
            //RegistrationNumber: EB8787MN

            Console.WriteLine(parking.RemoveCar("EB8787MN"));
            //Successfullyremoved EB8787MN

            Console.WriteLine(parking.Count); //1

        }

        public class Car
        {
            // constructor
            public Car(string make, string model, int hoursePower, string registrationNumber)
            {
                this.Make = make;
                this.Model = model;
                this.HorsePower = hoursePower;
                this.RegistrationNumber = registrationNumber;
            }

            // propraty
            public string Make { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
            public string RegistrationNumber { get; set; }

            public override string ToString()
            {
                string res = $"Make: {this.Make}" + Environment.NewLine;
                res += $"Model: {this.Model}" + Environment.NewLine;
                res += $"HousePower: {this.HorsePower}" + Environment.NewLine;
                res += $"RegistrationNumber: {this.RegistrationNumber}" + Environment.NewLine;

                return res;
            }
        }

        public class Parking
        {
            // field
            private List<Car> cars;
            private int capacity;

            // constructor
            public Parking(int capacity)
            {
                this.capacity = capacity;
                this.cars = new List<Car>();
            }

            // propraty
            public int Count => this.cars.Count;

            public string AddCar(Car car)
            {

                if (this.cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
                {
                    return "Car with that registration number, already exists!";
                }

                else if (this.cars.Count == this.capacity)
                {
                    return "Parking is full!";
                }

                this.cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }

            public Car GetCar(string RegistrationNumber)
            {
                Car car = this.cars.FirstOrDefault(cars => cars.RegistrationNumber == RegistrationNumber);

                return car;
            }

            public string RemoveCar(string RegistrationNumber)
            {
                Car car = this.cars.FirstOrDefault(cars => cars.RegistrationNumber == RegistrationNumber);

                if (car == null)
                {
                    return "Car with that registration number, doesn't exist!";
                }

                this.cars.Remove(car);
                return $"Successfully removed {RegistrationNumber}";
            }

            public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
            {
                this.cars = this.cars
                    .Where(c => !RegistrationNumbers.Contains(c.RegistrationNumber)).ToList();
            }
        }
    }
}
