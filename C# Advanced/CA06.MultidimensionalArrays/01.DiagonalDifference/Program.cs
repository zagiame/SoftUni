using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            // calculation
            var matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int sum = 0;
            int firstMatrix = 0;
            int secondMatrix = 0;

            for (int row = 0; row < n; row++)
            {
                int col = n - 1 - row;

                firstMatrix = firstMatrix + matrix[row, row];
                secondMatrix = secondMatrix + matrix[row, col];
            }

            // output
            sum = firstMatrix - secondMatrix;
            Console.WriteLine(Math.Abs(sum));
        }
    }
}
