using System;

namespace _01._Cinema
{
    class Program
    {

        // static data
        static double Premiere = 12.00;
        static double Normal = 7.50;
        static double Discount = 5.00;

        static void Main(string[] args)
        {
            // input
            double degrees = double.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            // calculation
            if (degrees >= 10 && degrees <= 18)
            {
                if (dayTime == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }

                else if (dayTime == "Afternoon" || dayTime == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            else if (degrees <= 24)
            {
                if (dayTime == "Morning" || dayTime == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (dayTime == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }

            else if (degrees >= 25)
            {
                if (dayTime == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }

                else if (dayTime == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }

                else if (dayTime == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            // output
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
