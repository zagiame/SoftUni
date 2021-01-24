using System;
using System.Xml.Schema;

namespace _01._Food_Delivery
{
    class Program
    {
        static double chiken = 10.35;
        static double fish = 12.40;
        static double vegetarian = 8.15;
        static double delivery = 2.50;

        static void Main(string[] args)
        {
            // input
            double chikenMenu = double.Parse(Console.ReadLine());
            double fishMenu = double.Parse(Console.ReadLine());
            double vegetarianMenu = double.Parse(Console.ReadLine());

            // calculation
            double menuPrice = chikenMenu * chiken + fishMenu * fish + vegetarianMenu * vegetarian;
            double desertPrice = menuPrice * 0.20;
            double totalPrice = menuPrice + desertPrice + delivery;

            // output
            Console.WriteLine($"Total: {totalPrice:f2}");
        }
    }
}
