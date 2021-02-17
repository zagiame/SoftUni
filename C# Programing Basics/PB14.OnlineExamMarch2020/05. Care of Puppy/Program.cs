using System;

namespace _05._Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double foodBought = double.Parse(Console.ReadLine());

            // calculation
            string operation = Console.ReadLine();
            double totalFoodEaten = 0;
            double foodConverted = foodBought * 1000;
            double foodLeft = 0;
            double foodEaten = 0;

            while (operation != "Adopted")
            {
                foodEaten = double.Parse(operation);
                foodConverted = foodConverted - foodEaten;
                operation = Console.ReadLine();
            }

            foodLeft = foodConverted - totalFoodEaten;

            // output

            if (operation == "Adopted" && foodConverted >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodLeft} grams.");
            }

            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(foodConverted)} grams more.");
            }

        }
    }
}
