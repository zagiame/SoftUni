using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int input = int.Parse(Console.ReadLine());

            // output
            PrintMatrix(input);
        }

        private static void PrintMatrix(int input)
        {

            for (int i = 0; i < input; i++)
            {
                int counter = 0;

                while (counter < input)
                {
                    counter++;
                    Console.Write(input + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
