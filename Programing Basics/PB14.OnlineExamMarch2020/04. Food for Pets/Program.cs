using System;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double dayNumber = double.Parse(Console.ReadLine());
            double FoodAmount = double.Parse(Console.ReadLine());

            // calculation
            double dayCounter = 0;
            double totalFoodEaten = 0;
            double totalFoodEatenByDog = 0;
            double totalFoodEatenByCat = 0;
            double totalBiscuitsEaten = 0;

            for (int i = 0; i < dayNumber; i++)
            {
                dayCounter++;
                double biscuitFor1Day = 0;
                double foodDog = double.Parse(Console.ReadLine());
                double foodCat = double.Parse(Console.ReadLine());
                double FoodEatenFot1Day = foodDog + foodCat;

                if (dayCounter % 3 == 0)
                {
                    biscuitFor1Day = FoodEatenFot1Day * 0.10;
                }

                totalFoodEaten = totalFoodEaten + FoodEatenFot1Day;
                totalFoodEatenByDog = totalFoodEatenByDog + foodDog;
                totalFoodEatenByCat = totalFoodEatenByCat + foodCat;
                totalBiscuitsEaten = totalBiscuitsEaten + biscuitFor1Day;

            }

            double percentTotal = totalFoodEaten / FoodAmount * 100;
            double percentDog = totalFoodEatenByDog / totalFoodEaten * 100;
            double percentCat = totalFoodEatenByCat / totalFoodEaten * 100;

            // output
            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalBiscuitsEaten)}gr.");
            Console.WriteLine($"{percentTotal:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentDog:f2}% eaten from the dog.");
            Console.WriteLine($"{percentCat:f2}% eaten from the cat.");
        }
    }
}
