using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        // field
        private List<Racer> data;

        // constructor
        public Race(string name, int capacity)
        {
            data = new List<Racer>();
            Name = name;
            Capacity = capacity;
        }

        // property
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get => data.Count(); }

        // method
        public void Add(Racer racer)
        {
            if (data.Count < Capacity)
            {
                data.Add(racer);
            }
        }

        public bool Remove(string name)
        {
            return data.Remove(data.FirstOrDefault(first => first.Name == name));
        }

        public Racer GetOldestRacer()
        {
            Racer oldest = data.OrderByDescending(first => first.Age).FirstOrDefault();
            return oldest;
        }

        public Racer GetRacer(string name)
        {
            Racer get = data.FirstOrDefault(first => first.Name == name);
            return get;
        }

        public Racer GetFastestRacer()
        {
            Racer fastest = data.OrderByDescending(first => first.Car.Speed).FirstOrDefault();
            return fastest;
        }

        public string Report()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Racer participating at {Name}:");

            foreach (var item in data)
            {
                text.AppendLine(item.ToString());
            }

            return text.ToString();
        }
    }

}
