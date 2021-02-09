using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        // field
        private Tire[] tires;

        // constructor
        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }

        // proprety
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Tire[] Tires
        {
            get => tires;
            set
            {
                if (value.Length == 4)
                {
                    tires = value;
                }
            }
        }

        // method

    }
}


