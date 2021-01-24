using System;

namespace _07._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            // static data


            // input
            double priceStrawberry = double.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double roseberries = double.Parse(Console.ReadLine());
            double strawberries = double.Parse(Console.ReadLine());

            // calculation
            double priceRoseberries = priceStrawberry - (priceStrawberry * 0.50);
            double priceOranges = priceRoseberries - (priceRoseberries * 0.40);
            double priceBananas = priceRoseberries - (priceRoseberries * 0.80);
            double totalStrawberries = priceStrawberry * strawberries;
            double totalRoseberries = priceRoseberries * roseberries;
            double totalBananas = priceBananas * bananas;
            double totalOranges = priceOranges * oranges;
            double totalPrice = totalStrawberries + totalRoseberries + totalBananas + totalOranges;

            // output
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
