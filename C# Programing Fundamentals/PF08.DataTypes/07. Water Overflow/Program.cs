using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int capacity = 255;
            int cycle = int.Parse(Console.ReadLine());

            // calculcation
            int sum = 0;

            for (int i = 0; i < cycle; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sum = sum + input;

                if (sum > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum = sum - input;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
