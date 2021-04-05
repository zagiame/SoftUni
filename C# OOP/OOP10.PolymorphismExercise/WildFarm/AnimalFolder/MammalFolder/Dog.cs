using System;

namespace WildFarm
{
    public class Dog : Mammal
    {

        private const double modifier = 0.40;

        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }

        public override void EatFood(string food, int quantity)
        {
            ProduceSound();

            if (food == "Meat")
            {
                Weight += quantity * modifier;
                FoodEaten += quantity;
            }

            else
            {
                Console.WriteLine($"{nameof(Dog)} does not eat {food}!");
            }
        }
    }
}