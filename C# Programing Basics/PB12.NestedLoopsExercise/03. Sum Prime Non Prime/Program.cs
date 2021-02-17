using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string operation = Console.ReadLine();

            int sumOfPrime = 0;
            int sumOfOdd = 0;

            while (operation != "stop")
            {
                int number = int.Parse(operation);
                int counter = 0;

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    operation = Console.ReadLine();
                    continue;
                }

                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (number != 1 && counter == 0)
                {
                    sumOfPrime = sumOfPrime + number;
                }
                else
                {
                    sumOfOdd = sumOfOdd + number;
                }

                operation = Console.ReadLine();

            }

            Console.WriteLine($"Sum of all prime numbers is: {sumOfPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfOdd}");

        }
    }
}
