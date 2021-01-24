using System;
using System.Linq;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // calculation
            string alphabet = ("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currentInput = input[i];
                char start = currentInput[0];
                char end = currentInput[currentInput.Length - 1];
                double number = double.Parse(currentInput.Substring(1, currentInput.Length - 2));

                int startIndex = alphabet.IndexOf(char.ToUpper(start)) + 1;
                int endIndex = alphabet.IndexOf(char.ToUpper(end)) + 1;

                if (IsUpper(start) == true)
                {
                    number = number / startIndex;
                }

                else
                {
                    number = number * startIndex;
                }

                if (IsUpper(end) == true)
                {
                    number = number - endIndex;
                }

                else
                {
                    number = number + endIndex;
                }

                // result
                sum = sum + number;
            }

            // output
            Console.WriteLine($"{sum:f2}");
        }

        public static bool IsUpper(char item)
        {
            if (item >= 65 && item <= 90)
            {
                return true;
            }

            return false;
        }
    }
}
