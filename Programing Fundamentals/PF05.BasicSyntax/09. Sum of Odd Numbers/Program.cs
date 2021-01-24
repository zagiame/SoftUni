using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int number = int.Parse(Console.ReadLine());

            // calculation
            int sum = 0;
            int counter = 0;

            for (int i = 1; i <= number; i++)
            {
                int odd = i + counter++;
                Console.WriteLine(odd);
                sum = sum + odd;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
