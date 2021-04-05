using System;

namespace WildFarm
{
    public class Mouse : Mammal
    {

        private const double modifier = 0.10;

        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Squeak");
        }

        public override void EatFood(string food, int quantity)
        {
            ProduceSound();

            if (food == "Vegetable" || food == "Fruit")
            {
                Weight += quantity * modifier;
                FoodEaten += quantity;
            }

            else
            {
                Console.WriteLine($"{nameof(Mouse)} does not eat {food}!");
            }
        }
    }
}