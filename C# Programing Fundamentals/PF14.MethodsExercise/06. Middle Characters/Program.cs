using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = Console.ReadLine();

            // ouput
            PrintResult(input);
        }

        private static void PrintResult(string input)
        {
            if (input.Length % 2 == 0)
            {
                int index = input.Length / 2;
                string output = input.Substring(index - 1, 2);
                Console.WriteLine(output);
            }

            else
            {
                int index = input.Length / 2;
                string output = input.Substring(index, 1);
                Console.WriteLine(output);
            }
        }
    }
}
