using System;

namespace _01.DisneylandJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double budget = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());

            // calculation
            double money = 0;
            int count = 0;

            for (int i = 0; i < months; i++)
            {
                count++;

                if (count % 2 == 1)
                {
                    money = money - money * 0.16;
                }

                if (count % 4 == 0)
                {
                    money = money + money * 0.25;
                }

                money = money + budget * 0.25;
            }

            // ouput
            double moneyLeft = money - budget;
            double moneyNeeded = budget - money;

            if (money > budget)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {moneyLeft:f2}lv. for souvenirs.");
            }

            else
            {
                Console.WriteLine($"Sorry. You need {moneyNeeded:f2}lv. more.");
            }
        }
    }
}
