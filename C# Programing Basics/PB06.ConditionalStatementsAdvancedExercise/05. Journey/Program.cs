using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {


            // input
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            // calculation
            double totalPrice = 0;
            string destination = "";
            string hosting = "";

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    totalPrice = budget * 0.30;
                    hosting = "Camp";
                }

                else if (season == "winter")
                {
                    totalPrice = budget * 0.70;
                    hosting = "Hotel";
                }

                destination = "Bulgaria";
            }


            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    totalPrice = budget * 0.40;
                    hosting = "Camp";
                }

                else if (season == "winter")
                {
                    totalPrice = budget * 0.80;
                    hosting = "Hotel";
                }

                destination = "Balkans";
            }

            else
            {
                hosting = "Hotel";
                totalPrice = budget * 0.90;
                destination = "Europe";
            }

            // output
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{hosting} - {totalPrice:f2}");
        }
    }
}
