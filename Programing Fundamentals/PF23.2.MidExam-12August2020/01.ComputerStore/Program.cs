using System;

namespace _01.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = Console.ReadLine();

            // calculation
            double price = 0;

            while (input != "special" && input != "regular")
            {
                double currentInput = double.Parse(input);

                if (currentInput < 0)
                {
                    Console.WriteLine("Invalid price!");

                    input = Console.ReadLine();
                    continue;
                }

                price = price + currentInput;

                input = Console.ReadLine();
            }

            double tax = price * 0.2;
            double totalPrice = price + tax;

            if (input == "special")
            {
                totalPrice = totalPrice - (totalPrice * 0.1);
            }


            // output
            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }

            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {price:f2}$");
                Console.WriteLine($"Taxes: {tax:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
        }
    }
}
