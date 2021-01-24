using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        // static data
        static double priceSpring = 3000;
        static double priceSummerAutumn = 4200;
        static double priceWinter = 2600;

        static void Main(string[] args)
        {

            //input
            double budget = double.Parse(Console.ReadLine());
            string seasonName = Console.ReadLine();
            int sailorsNumber = int.Parse(Console.ReadLine());

            //calculation
            double seasonPrice = 0;
            double finalPrice = 0;


            switch (seasonName)
            {
                case "Spring":
                    seasonPrice = priceSpring;
                    break;
                case "Summer":
                    seasonPrice = priceSummerAutumn;
                    break;
                case "Autumn":
                    seasonPrice = priceSummerAutumn;
                    break;
                case "Winter":
                    seasonPrice = priceWinter;
                    break;
            }


            if (sailorsNumber <= 6)
            {
                finalPrice = seasonPrice - (seasonPrice * 0.10);
            }
            else if (sailorsNumber >= 7 && sailorsNumber <= 11)
            {
                finalPrice = seasonPrice - (seasonPrice * 0.15);
            }
            else if (sailorsNumber >= 12)
            {
                finalPrice = seasonPrice - (seasonPrice * 0.25);
            }
            if (sailorsNumber % 2 == 0 && seasonName != "Autumn")
            {
                finalPrice = finalPrice - (finalPrice * 0.05);
            }

            //output
            if (budget >= finalPrice)
            {
                double moneyLeft = budget - finalPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else if (finalPrice > budget)
            {
                double moneyNeeded = finalPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
        }
    }
}
