using System;
using System.Collections.Generic;
using System.Text;

namespace TheRace
{
    public class Car
    {
        // constructor
        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        // property
        public string Name { get; set; }
        public int Speed { get; set; }

    }
}
