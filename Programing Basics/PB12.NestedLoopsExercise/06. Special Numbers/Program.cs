using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int a = 1; a <= 9; a++)
                {
                    for (int b = 1; b <= 9; b++)
                    {

                        for (int c = 1; c <= 9; c++)
                        {
                            if (number % i == 0 && number % a == 0 && number % b == 0 && number % c == 0)
                            {
                                Console.Write("" + i + a + b + c + " ");
                            }
                        }
                    }
                }
            }

        }
    }
}
