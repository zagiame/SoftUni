using System;
using System.Xml;

namespace _06._Vet_Parking
{
    class Program
    {
        // static data
        static double pricePrimeDayOddHour = 2.50;
        static double priceOddDayPrimeHour = 1.25;
        static double priceHour = 1.00;


        static void Main(string[] args)
        {
            // input
            double days = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            // calculation
            double dayCounter = 0;
            double totalPrice = 0;

            for (int d = 1; d <= days; d++)
            {
                dayCounter++;
                double hourCounter = 0;
                double totalPricePerDay = 0;
                double pricePerHour = 0;
                double totalPriceNormalHour = 0;
                double totalPriceOddHour = 0;
                double totalPricePrimeHour = 0;

                for (int h = 1; h <= hours; h++)
                {
                    hourCounter++;

                    if (dayCounter % 2 != 0 && hourCounter % 2 == 0)
                    {
                        pricePerHour = priceOddDayPrimeHour;
                        totalPricePrimeHour = totalPricePrimeHour + pricePerHour;
                    }

                    else if (dayCounter % 2 == 0 && hourCounter % 2 != 0)
                    {
                        pricePerHour = pricePrimeDayOddHour;
                        totalPriceOddHour = totalPriceOddHour + pricePerHour;
                    }

                    else
                    {
                        pricePerHour = priceHour;
                        totalPriceNormalHour = totalPriceNormalHour + pricePerHour;
                    }

                    totalPricePerDay = totalPriceNormalHour + totalPricePrimeHour + totalPriceOddHour;
                }

                Console.WriteLine($"Day: {dayCounter} - {totalPricePerDay:f2} leva");
                totalPrice = totalPrice + totalPricePerDay;
            }

            Console.WriteLine($"Total: {totalPrice:f2} leva");


        }
    }
}
