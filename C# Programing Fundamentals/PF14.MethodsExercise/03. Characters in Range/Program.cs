using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            // ouput
            PrintTable(firstChar, secondChar);
        }

        private static void PrintTable(char firstChar, char secondChar)
        {
            char start = firstChar;
            char end = secondChar;

            if (secondChar < firstChar)
            {
                start = secondChar;
                end = firstChar;
            }

            for (int i = start + 1; i < end; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}