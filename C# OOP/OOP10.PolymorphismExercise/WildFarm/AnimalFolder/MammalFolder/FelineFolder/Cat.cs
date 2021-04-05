using System;

namespace WildFarm
{
    public class Cat : Feline
    {

        private const double modifier = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }

        public override void EatFood(string food, int quantity)
        {
            ProduceSound();

            if (food == "Vegetable" || food == "Meat")
            {
                Weight += quantity * modifier;
                FoodEaten += quantity;
            }

            else
            {
                Console.WriteLine($"{nameof(Cat)} does not eat {food}!");
            }
        }

    }
}