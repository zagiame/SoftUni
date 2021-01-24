using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] specialNumber = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // calculation
            int bomb = specialNumber[0];
            int power = specialNumber[1];

            for (int index = 0; index < input.Count; index++)
            {
                int currentNumber = input[index];

                if (currentNumber == bomb)
                {
                    int startIndex = index - power;
                    int endIndex = index + power;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                    }

                    int removeCounter = endIndex - startIndex + 1;
                    input.RemoveRange(startIndex, removeCounter);

                    index = startIndex - 1;
                }
            }

            // output
            Console.WriteLine(input.Sum());
        }
    }
}
