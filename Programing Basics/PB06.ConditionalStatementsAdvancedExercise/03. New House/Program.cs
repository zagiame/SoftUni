using System;

namespace _03._New_House
{
    class Program
    {
        // static data
        static double Roses = 5;
        static double Dahlias = 3.80;
        static double Tulips = 2.80;
        static double Narcissus = 3;
        static double Gladiolus = 2.50;

        static void Main(string[] args)
        {

            // input
            string flowerType = Console.ReadLine();
            double flowerNumber = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            // calculation
            double totalSum = 0;
            double discount = 0;

            if (flowerType == "Roses")
            {
                if (flowerNumber > 80)
                {
                    discount = flowerNumber * Roses * 0.10;
                }
                totalSum = (flowerNumber * Roses) - discount;
            }

            else if (flowerType == "Dahlias")
            {
                if (flowerNumber > 90)
                {
                    discount = flowerNumber * Dahlias * 0.15;
                }
                totalSum = (flowerNumber * Dahlias) - discount;
            }

            else if (flowerType == "Tulips")
            {
                if (flowerNumber > 80)
                {
                    discount = flowerNumber * Tulips * 0.15;
                }
                totalSum = (flowerNumber * Tulips) - discount;
            }

            else if (flowerType == "Narcissus")
            {
                if (flowerNumber < 120)
                {
                    discount = flowerNumber * Narcissus * 0.15;
                }
                totalSum = (flowerNumber * Narcissus) + discount;

            }

            else if (flowerType == "Gladiolus")
            {
                if (flowerNumber < 80)
                {
                    discount = flowerNumber * Gladiolus * 0.20;
                }
                totalSum = (flowerNumber * Gladiolus) + discount;
            }

            double sumLeft = budget - totalSum;
            double moneyNeeded = totalSum - budget;

            // output
            if (budget >= totalSum)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerNumber} {flowerType} and {sumLeft:f2} leva left.");
            }

            else if (totalSum > budget)
            {
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }
        }
    }
}
