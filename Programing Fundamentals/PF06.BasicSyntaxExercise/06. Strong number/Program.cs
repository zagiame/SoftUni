using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int input = int.Parse(Console.ReadLine());

            // calcucaltion
            int number = input;
            int factorialSum = 0;

            while (number != 0)
            {
                int currentNumber = number % 10;
                number = number / 10;

                int factorial = 1;

                for (int i = 1; i <= currentNumber; i++)
                {
                    factorial = factorial * i;
                }

                factorialSum = factorialSum + factorial;
            }

            string result = string.Empty;

            if (input == factorialSum)
            {
                result = "yes";
            }
            else
            {
                result = "no";
            }

            Console.WriteLine(result);
        }
    }
}
