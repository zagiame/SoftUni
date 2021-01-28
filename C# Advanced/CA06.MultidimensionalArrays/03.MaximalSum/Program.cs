using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = data[0];
            int m = data[1];

            // calculation
            var matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int maxSum = int.MinValue;
            int rowIndex = -1;
            int colIndex = -1;

            for (int row = 0; row < n - 2; row++)
            {

                for (int col = 0; col < m - 2; col++)
                {
                    int currentSum = 0;

                    currentSum = currentSum
                        + matrix[row, col]
                        + matrix[row, col + 1]
                        + matrix[row, col + 2]

                        + matrix[row + 1, col]
                        + matrix[row + 1, col + 1]
                        + matrix[row + 1, col + 2]

                        + matrix[row + 2, col]
                        + matrix[row + 2, col + 1]
                        + matrix[row + 2, col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }

            // output
            Console.WriteLine($"Sum = {maxSum}");

            for (int printRow = rowIndex; printRow < rowIndex + 3; printRow++)
            {
                for (int printCol = colIndex; printCol < colIndex + 3; printCol++)
                {
                    Console.Write(matrix[printRow, printCol] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
