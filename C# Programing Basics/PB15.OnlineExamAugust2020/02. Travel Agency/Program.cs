using System;

namespace _02._Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double numberOfTickets = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double priceFor1Ticket = double.Parse(Console.ReadLine());

            // calculation
            double totalTicketsPrice = numberOfTickets * priceFor1Ticket;

            // output
            if (budget >= totalTicketsPrice)
            {
                double moneyLeft = budget - totalTicketsPrice;
                Console.WriteLine($"You can sell your client {numberOfTickets} tickets for the price of {totalTicketsPrice}$!");
                Console.WriteLine($"Your client should become a change of {moneyLeft}$!");
            }

            else if (budget < totalTicketsPrice)
            {
                Console.WriteLine($"The budget of {budget}$ is not enough. Your client can't buy {numberOfTickets} tickets with this budget!");
            }

        }
    }
}
