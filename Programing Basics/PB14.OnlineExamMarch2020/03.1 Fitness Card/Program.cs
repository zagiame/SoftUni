using System;

namespace _03._1_Fitness_Card
{
    class Program
    {
        // static data Male
        static double gymMale = 42;
        static double boxingMale = 41;
        static double yogaMale = 45;
        static double zumbaMale = 34;
        static double dancesMale = 51;
        static double pilatesMale = 39;

        // static data Female
        static double gymFemale = 35;
        static double boxingFemale = 37;
        static double yogaFemale = 42;
        static double zumbaFemale = 41;
        static double dancesFemale = 53;
        static double pilatesFemale = 37;

        static void Main(string[] args)
        {
            // input
            double budget = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());
            string sportType = Console.ReadLine();

            // calculation
            double cardPrice = 0;

            if (gender == "m")
            {
                switch (sportType)
                {
                    case "Gym":
                        cardPrice = gymMale;
                        break;

                    case "Boxing":
                        cardPrice = boxingMale;
                        break;

                    case "Yoga":
                        cardPrice = yogaMale;
                        break;

                    case "Zumba":
                        cardPrice = zumbaMale;
                        break;

                    case "Dances":
                        cardPrice = dancesMale;
                        break;

                    case "Pilates":
                        cardPrice = pilatesMale;
                        break;

                }
            }

            else if (gender == "f")
            {
                switch (sportType)
                {
                    case "Gym":
                        cardPrice = gymFemale;
                        break;

                    case "Boxing":
                        cardPrice = boxingFemale;
                        break;

                    case "Yoga":
                        cardPrice = yogaFemale;
                        break;

                    case "Zumba":
                        cardPrice = zumbaFemale;
                        break;

                    case "Dances":
                        cardPrice = dancesFemale;
                        break;

                    case "Pilates":
                        cardPrice = pilatesFemale;
                        break;

                }
            }


            if (age <= 19)
            {
                cardPrice = cardPrice - (cardPrice * 0.20);
            }

            if (budget >= cardPrice)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sportType}.");
            }

            else if (budget < cardPrice)
            {
                double moneyNeeded = cardPrice - budget;
                Console.WriteLine($"You don't have enough money! You need ${moneyNeeded:f2} more.");
            }
        }
    }
}
