using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] input = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            // calculation
            bool isBigger = true;

            for (int i = 0; i < input.Length; i++)
            {
                int currentInput = input[i];

                for (int j = i + 1; j < input.Length; j++)
                {
                    if (currentInput <= input[j])
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger == true)
                {
                    Console.Write($"{input[i]} ");
                }

                isBigger = true;
            }
        }
    }
}
