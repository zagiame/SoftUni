using System;

namespace _03._Kart_Center
{
    class Program
    {
        // static data 5 rounds
        static double childFiveRounds = 7;
        static double juniorFiveRounds = 9;
        static double adultFiveRounds = 12;
        static double profiFiveRounds = 18;

        // static data 10 rounds
        static double childTenRounds = 11;
        static double juniorTenRounds = 16;
        static double adultTenRounds = 21;
        static double profiTenRounds = 32;

        static void Main(string[] args)
        {
            // input
            double budget = double.Parse(Console.ReadLine());
            string rounds = Console.ReadLine();
            string cardOption = Console.ReadLine();
            string ageOption = Console.ReadLine();

            // calculation
            double cardPrice = 0;

            if (rounds == "five")
            {
                switch (ageOption)
                {
                    case "Child":
                        cardPrice = childFiveRounds;
                        break;

                    case "Junior":
                        cardPrice = juniorFiveRounds;
                        break;

                    case "Adult":
                        cardPrice = adultFiveRounds;
                        break;

                    case "Profi":
                        cardPrice = profiFiveRounds;
                        break;
                }
            }

            else if (rounds == "ten")
            {
                switch (ageOption)
                {
                    case "Child":
                        cardPrice = childTenRounds;
                        break;

                    case "Junior":
                        cardPrice = juniorTenRounds;
                        break;

                    case "Adult":
                        cardPrice = adultTenRounds;
                        break;

                    case "Profi":
                        cardPrice = profiTenRounds;
                        break;
                }

            }

            if (cardOption == "yes")
            {
                cardPrice = cardPrice - (cardPrice * 0.20);
            }

            // output
            if (cardPrice <= budget)
            {
                double moneyLeft = budget - cardPrice;
                Console.WriteLine($"You bought {ageOption} ticket for {rounds} laps. Your change is {moneyLeft:f2}lv.");
            }

            else if (cardPrice > budget)
            {
                double moneyNeeded = cardPrice - budget;
                Console.WriteLine($"You don't have enough money! You need {moneyNeeded:f2}lv more.");
            }
        }
    }
}
