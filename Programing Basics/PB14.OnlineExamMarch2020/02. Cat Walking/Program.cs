using System;

namespace _02._Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double walkMinutes = double.Parse(Console.ReadLine());
            double numberOfWalks = double.Parse(Console.ReadLine());
            double caloriesIntake = double.Parse(Console.ReadLine());

            // calculation
            double caloriesBurnedPerMinute = 5;
            double enoughWalk = caloriesIntake / 2;
            double totalWalk = walkMinutes * numberOfWalks;
            double burnedCalories = totalWalk * caloriesBurnedPerMinute;

            // output
            if (burnedCalories >= enoughWalk)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCalories}.");
            }

            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCalories}.");

            }
        }
    }
}
