using System;
using System.Collections.Generic;
using System.Text;

namespace TheRace
{
    public class Racer
    {
        // constructor
        public Racer(string name, int age, string country, Car car)
        {
            Name = name;
            Age = age;
            Country = country;
            Car = car;
        }

        // property
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public Car Car { get; set; }

        // method
        public override string ToString()
        {
            string toPrint = $"Racer: {Name}, {Age} ({Country})";
            return toPrint;
        }
    }
}
