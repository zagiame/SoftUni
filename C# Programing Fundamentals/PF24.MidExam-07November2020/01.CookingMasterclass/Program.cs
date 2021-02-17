using System;

namespace _01.CookingMasterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            // calculation
            int freePackages = 0;

            for (int i = 1; i <= students; i++)
            {
                if (i % 5 == 0)
                {
                    freePackages++;
                }
            }

            double extraApron = (students + students * 0.20);

            double totalPrice =
                apronPrice * Math.Ceiling(extraApron)
                + eggPrice * 10 * (students)
                + flourPrice * (students - freePackages);

            // output
            double neededMoney = totalPrice - budget;

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Items purchased for {totalPrice:f2}$.");
            }

            else
            {
                Console.WriteLine($"{neededMoney:f2}$ more needed.");
            }
        }
    }
}
