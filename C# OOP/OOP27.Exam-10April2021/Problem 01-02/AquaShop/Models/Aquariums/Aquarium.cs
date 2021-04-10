using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Utilities.Messages;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private IList<IDecoration> decorationList;
        private IDictionary<string, IFish> fishByName;

        private string name;
        // private int capacity;

        protected Aquarium(string name, int capacity)
        {
            decorationList = new List<IDecoration>();
            fishByName = new Dictionary<string, IFish>();

            Name = name;
            Capacity = capacity;
        }

        public string Name
        {
            get => name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidAquariumName);
                }

                else
                {
                    name = value;
                }
            }
        }

        public int Capacity { get; private set; }

        public int Comfort => decorationList.Sum(v => v.Comfort);

        public ICollection<IDecoration> Decorations => decorationList.ToList();

        public ICollection<IFish> Fish => fishByName.Values.ToList();

        public void AddFish(IFish fish)
        {
            if (fishByName.Count == Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }

            else
            {
                fishByName.Add(fish.Name, fish);
            }
        }

        public bool RemoveFish(IFish fish)
        {
            return fishByName.Remove(fish.Name);
        }

        public void AddDecoration(IDecoration decoration)
        {
            decorationList.Add(decoration);
        }

        public void Feed()
        {
            foreach (var fish in fishByName.Values)
            {
                fish.Eat();
            }
        }

        public string GetInfo()
        {
            var text = new StringBuilder();
            text.AppendLine($"{Name} ({GetType().Name}):");

            if (fishByName.Count == 0)
            {
                text.AppendLine("none");
            }

            else
            {
                text.AppendLine(string.Join(", ", fishByName.Values));
            }

            text.AppendLine($"Decorations: {decorationList.Count}");
            text.AppendLine($"Comfort: {Comfort}");

            return text.ToString().TrimEnd();
        }
    }
}