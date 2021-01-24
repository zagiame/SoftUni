using System;

namespace _01._1_Supplies_for_School
{
    class Program
    {
        // static data
        static double packPen = 5.80;
        static double packPencil = 7.20;
        static double packClenaer = 1.20;


        static void Main(string[] args)
        {
            // input
            double penNumber = double.Parse(Console.ReadLine());
            double pencilNumber = double.Parse(Console.ReadLine());
            double cleanerNumber = double.Parse(Console.ReadLine());
            double discountNumber = double.Parse(Console.ReadLine());

            // calculation
            double penTotal = penNumber * packPen;
            double pencilTotal = pencilNumber * packPencil;
            double cleanerTotal = cleanerNumber * packClenaer;
            double priceBeforeDiscount = penTotal + pencilTotal + cleanerTotal;
            double discount = priceBeforeDiscount * discountNumber / 100;
            double totalSum = priceBeforeDiscount - discount;

            // output
            Console.WriteLine($"{totalSum:f3}");
        }
    }
}
