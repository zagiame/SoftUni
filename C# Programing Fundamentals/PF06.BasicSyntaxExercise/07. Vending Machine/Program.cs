using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string command = Console.ReadLine();

            // calculation
            double sum = 0;

            while (command != "Start")
            {
                double moneyInput = double.Parse(command);

                if (moneyInput == 0.1 || moneyInput == 0.2 || moneyInput == 0.5 || moneyInput == 1 || moneyInput == 2)
                {
                    sum = sum + moneyInput;
                }

                else
                {
                    Console.WriteLine($"Cannot accept {moneyInput}");
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                double productPrice = 0;

                switch (command)
                {
                    case "Nuts":
                        productPrice = 2;
                        break;

                    case "Water":
                        productPrice = 0.7;
                        break;

                    case "Crisps":
                        productPrice = 1.5;
                        break;

                    case "Soda":
                        productPrice = 0.8;
                        break;

                    case "Coke":
                        productPrice = 1;
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        command = Console.ReadLine();
                        continue;
                }

                if (sum < productPrice)
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                else
                {
                    sum = sum - productPrice;
                    Console.WriteLine($"Purchased {command.ToLower()}");
                }

                command = Console.ReadLine();

            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
