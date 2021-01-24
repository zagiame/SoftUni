using System;

namespace _02._Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double score = double.Parse(Console.ReadLine());

            // output
            if (score >= 3)
            {
                Console.WriteLine("Passed!");
            }

        }
    }
}
