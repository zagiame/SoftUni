using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int number = int.Parse(Console.ReadLine());

            // calculation
            int rowCounter = 0;

            for (int i = 1; i <= number; i++)
            {
                rowCounter++;
                int position = 0;

                while (position != rowCounter)
                {
                    position++;
                    Console.Write($"{i} ");
                }

                Console.WriteLine();
            }
        }
    }
}
