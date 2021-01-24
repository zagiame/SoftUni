using System;

namespace _02._First_Steps_in_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double usd = double.Parse(Console.ReadLine());

            // calculation
            double bgn = usd * 1.79549;

            // output
            Console.WriteLine($"{bgn:f2}");
        }
    }
}
