using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class Pizza
    {
        // constant
        private const int NameMinLenght = 1;
        private const int NameMaxLenght = 15;
        private const int MinToppingCount = 0;
        private const int MaxToppingCount = 10;

        // field
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        // constructor
        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.dough = dough;
            this.toppings = new List<Topping>();
        }

        // property
        public string Name
        {
            get => this.name;

            private set
            {
                if (value.Length < NameMinLenght || value.Length > NameMaxLenght)
                {
                    throw new ArgumentException($"Pizza name should be between {NameMinLenght} and {NameMaxLenght} symbols.");
                }

                this.name = value;
            }
        }

        // method
        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count == MaxToppingCount)
            {
                throw new InvalidOperationException($"Number of toppings should be in range [{MinToppingCount}..{MaxToppingCount}].");
            }

            this.toppings.Add(topping);
        }

        public double GetCalories()
        {
            var doughCalories = this.dough.GetCalories();
            var toppingCalories = this.toppings.Sum(first => first.GetCalories());

            return doughCalories + toppingCalories;
        }

    }
}