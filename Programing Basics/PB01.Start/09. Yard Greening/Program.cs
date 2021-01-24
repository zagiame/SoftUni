using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double garden = double.Parse(Console.ReadLine());
            
            // calculations
            double price = garden * 7.61;
            double discount = 0.18 * price;
            double final = price - discount;

            // output
            Console.WriteLine($"The final price is: {final:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");
        }
    }
}