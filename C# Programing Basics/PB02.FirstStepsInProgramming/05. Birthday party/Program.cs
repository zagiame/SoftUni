using System;

namespace _05._Birthday_party
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double rent = double.Parse(Console.ReadLine());

            // calcualtion
            double cake = rent * 0.20;
            double drinks = cake - (cake * 0.45);
            double animator = rent * 1 / 3;
            double budget = rent + cake + drinks + animator;

            // output
            Console.WriteLine(budget);
        }
    }
}
