using System;

namespace WildFarm
{
    public class Tiger : Feline
    {

        private const double modifier = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("ROAR!!!");
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
                Console.WriteLine($"{nameof(Tiger)} does not eat {food}!");
            }
        }
    }
}