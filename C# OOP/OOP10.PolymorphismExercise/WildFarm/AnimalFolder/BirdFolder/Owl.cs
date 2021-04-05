using System;

namespace WildFarm
{
    public class Owl : Bird
    {
        private const double modifier = 0.25;

        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
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
                Console.WriteLine($"{nameof(Owl)} does not eat {food}!");
            }
        }
    }
}