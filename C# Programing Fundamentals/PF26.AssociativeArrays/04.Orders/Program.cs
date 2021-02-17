using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = string.Empty;

            // calculation
            var list = new Dictionary<string, double[]>();

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] currentInput = input.Split();
                string productName = currentInput[0];
                double price = double.Parse(currentInput[1]);
                double quantity = double.Parse(currentInput[2]);

                double[] priceAndQuantity = { 0, 0 };

                if (list.ContainsKey(productName) == false)
                {
                    list.Add(currentInput[0], priceAndQuantity);
                }

                list[productName][0] = price;
                list[productName][1] = list[productName][1] + quantity;
            }

            // output
            foreach (var item in list)
            {
                double totalPrice = item.Value[0] * item.Value[1];

                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}
