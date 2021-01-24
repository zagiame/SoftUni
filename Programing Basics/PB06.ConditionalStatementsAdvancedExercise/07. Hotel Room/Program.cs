using System;

namespace _07._Hotel_Room
{
    class Program
    {
        // static data
        static double studioMayOctober = 50;
        static double studioJuneSeptember = 75.20;
        static double studioJulyAugust = 76;
        static double apartmentMayOctober = 65;
        static double apartmentJuneSeptember = 68.70;
        static double apartmentJulyAugust = 77;

        static void Main(string[] args)
        {
            // input
            string month = Console.ReadLine();
            int numberOfDays = int.Parse(Console.ReadLine());

            // calculation
            double discountStudio = 0;
            double discountApartment = 0;
            double totalPriceStudio = 0;
            double totalPriceApartment = 0;

            if (month == "May" || month == "October")
            {
                if (numberOfDays > 7 && numberOfDays < 14)
                {
                    discountStudio = studioMayOctober * numberOfDays * 0.05;
                }

                else if (numberOfDays > 14)
                {
                    discountStudio = studioMayOctober * numberOfDays * 0.30;
                    discountApartment = apartmentMayOctober * numberOfDays * 0.10;
                }

                totalPriceStudio = (studioMayOctober * numberOfDays) - discountStudio;
                totalPriceApartment = (apartmentMayOctober * numberOfDays) - discountApartment;

                Console.WriteLine($"Apartment: {totalPriceApartment:f2} lv.");
                Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
            }

            else if (month == "June" || month == "September")
            {
                if (numberOfDays > 14)
                {
                    discountStudio = studioJuneSeptember * numberOfDays * 0.20;
                    discountApartment = apartmentJuneSeptember * numberOfDays * 0.10;
                }

                totalPriceStudio = (studioJuneSeptember * numberOfDays) - discountStudio;
                totalPriceApartment = (apartmentJuneSeptember * numberOfDays) - discountApartment;

                Console.WriteLine($"Apartment: {totalPriceApartment:f2} lv.");
                Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
            }


            else if (month == "July" || month == "August")
            {
                if (numberOfDays > 14)
                {
                    discountApartment = apartmentJulyAugust * numberOfDays * 0.10;
                }

                totalPriceStudio = studioJulyAugust * numberOfDays;
                totalPriceApartment = (apartmentJulyAugust * numberOfDays) - discountApartment;

                Console.WriteLine($"Apartment: {totalPriceApartment:f2} lv.");
                Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
            }
        }
    }
}
