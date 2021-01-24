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
            string typeProjection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            // calculation
            double income = 0.0;

            // output
            if (typeProjection == "Premiere")
            {
                income = row * column * Premiere;
            }

            else if (typeProjection == "Normal")
            {
                income = row * column * Normal;
            }

            else if (typeProjection == "Discount")
            {
                income = row * column * Discount;
            }

            Console.WriteLine($"{income:f2} leva");
        }
    }
}
