using System;

namespace _02._Safari
{
    class Program
    {
        // static data
        static double gasPrice = 2.10;
        static double guide = 100;

        static void Main(string[] args)
        {
            // input
            double budget = double.Parse(Console.ReadLine());
            double gasNeeded = double.Parse(Console.ReadLine());
            string weekDay = Console.ReadLine();

            // calculation
            double gasTotalPrice = gasNeeded * gasPrice;
            double totalVacationPrice = gasTotalPrice + guide;
            double moneyLeft = 0;
            double moneyNeeded = 0;

            // output
            if (weekDay == "Saturday")
            {
                totalVacationPrice = totalVacationPrice - (totalVacationPrice * 0.10);
                moneyLeft = budget - totalVacationPrice;
                moneyNeeded = totalVacationPrice - budget;

                if (budget > totalVacationPrice)
                {
                    Console.WriteLine($"Safari time! Money left: {moneyLeft:f2} lv.");
                }

                else
                {
                    Console.WriteLine($"Not enough money! Money needed: {moneyNeeded:f2} lv.");
                }
            }

            else if (weekDay == "Sunday")
            {
                totalVacationPrice = totalVacationPrice - (totalVacationPrice * 0.20);
                moneyLeft = budget - totalVacationPrice;
                moneyNeeded = totalVacationPrice - budget;

                if (budget > totalVacationPrice)
                {
                    Console.WriteLine($"Safari time! Money left: {moneyLeft:f2} lv.");
                }

                else
                {
                    Console.WriteLine($"Not enough money! Money needed: {moneyNeeded:f2} lv.");
                }
            }

            else
            {
                moneyLeft = budget - totalVacationPrice;
                moneyNeeded = totalVacationPrice - budget;

                if (budget > totalVacationPrice)
                {
                    Console.WriteLine($"Safari time! Money left: {moneyLeft:f2} lv.");
                }

                else
                {
                    Console.WriteLine($"Not enough money! Money needed: {moneyNeeded:f2} lv.");
                }
            }
        }
    }
}


