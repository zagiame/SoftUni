using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            // calculation
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
