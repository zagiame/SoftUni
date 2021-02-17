using System;
using System.Linq;

namespace _06._Equal_Sum
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
            int rightSum = 0;
            int leftSum = 0;

            for (int currentInput = 0; currentInput < input.Length; currentInput++)
            {
                rightSum = 0;
                leftSum = 0;

                for (int i = currentInput + 1; i < input.Length; i++)
                {
                    rightSum = rightSum + input[i];
                }

                for (int i = currentInput - 1; i >= 0; i--)
                {
                    leftSum = leftSum + input[i];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(currentInput);
                    break;
                }
            }

            if (leftSum != rightSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
