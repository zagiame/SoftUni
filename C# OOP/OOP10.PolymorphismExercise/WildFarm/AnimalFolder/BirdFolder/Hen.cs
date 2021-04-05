using System;

namespace WildFarm
{
    public class Hen : Bird
    {
        private const double modifier = 0.35;

        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }

        public override void EatFood(string food, int quantity)
        {
            ProduceSound();

            Weight += quantity * modifier;
            FoodEaten += quantity;

        }
    }
}