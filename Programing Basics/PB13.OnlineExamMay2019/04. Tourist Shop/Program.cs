using System;

namespace _04._Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double budget = double.Parse(Console.ReadLine());
            string opretation = "";
            int productCounter = 0;
            double moneySpent = 0;

            while (true)
            {
                opretation = Console.ReadLine();

                if (opretation == "Stop")
                {
                    break;
                }

                double productPrice = double.Parse(Console.ReadLine());
                productCounter++;

                if (productCounter % 3 == 0)
                {
                    productPrice = productPrice / 2;
                }

                if (budget < productPrice)
                {
                    double moneyNeeded = productPrice - budget;
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {moneyNeeded:f2} leva!");
                    break;
                }

                budget = budget - productPrice;
                moneySpent = moneySpent + productPrice;

            }

            if (opretation == "Stop")
            {
                Console.WriteLine($"You bought {productCounter} products for {moneySpent:f2} leva.");
            }
        }
    }
}
