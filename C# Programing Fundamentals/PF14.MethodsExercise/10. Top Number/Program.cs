using System;
using System.Transactions;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int input = int.Parse(Console.ReadLine());

            // output
            PrintTopNumber(input);
        }

        private static void PrintTopNumber(int input)
        {
            for (int i = 0; i < input; i++)
            {
                string currentNumber = i.ToString();
                bool isOddDigit = false;
                int sumOfDigits = 0;

                foreach (var item in currentNumber)
                {
                    int number = (int)item;

                    if (number % 2 == 1)
                    {
                        isOddDigit = true;
                    }

                    sumOfDigits = sumOfDigits + number;
                }

                if (sumOfDigits % 8 == 0 && isOddDigit == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
