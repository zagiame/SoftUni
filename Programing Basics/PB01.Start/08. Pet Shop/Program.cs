using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int pet1 = int.Parse(Console.ReadLine());
            int pet2 = int.Parse(Console.ReadLine());
            double price = pet1 * 2.5 + pet2 * 4;


            Console.WriteLine($"{price} lv.");
        }
    }
}
