using System;
using System.Diagnostics.Tracing;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = Console.ReadLine().ToLower();

            // calculation
            int result = VowelsCount(input);

            // output
            Console.WriteLine(result);
        }

        private static int VowelsCount(string input)
        {
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == 'a' || currentChar == 'e' ||
                    currentChar == 'i' || currentChar == 'o' ||
                    currentChar == 'u' || currentChar == 'y')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
