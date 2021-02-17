using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {

            // static data


            // input
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double priceForClothes = double.Parse(Console.ReadLine());

            // calculation
            double decor = budget * 0.10;
            if (statists > 150)
            {
                priceForClothes *= 0.90;
            }
            double finalPriceForClothes = priceForClothes * statists;
            double finalMoney = decor + finalPriceForClothes;
            double moneyLeft = budget - finalMoney;
            double needMoney = finalMoney - budget;

            // output
            if (finalMoney <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {needMoney:f2} leva more.");
            }

        }
    }
}
