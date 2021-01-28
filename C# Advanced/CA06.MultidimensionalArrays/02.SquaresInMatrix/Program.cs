using System;
using System.Linq;

namespace _02.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = data[0];
            int m = data[1];

            // calculation
            var matrix = new string[n, m];

            for (int row = 0; row < n; row++)
            {
                string[] input = Console.ReadLine().Split();

                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int count = 0;

            for (int row = 0; row < n; row++)
            {

                for (int col = 0; col < m; col++)
                {
                    bool isValid = col + 1 < m && row + 1 < n
                        && matrix[row, col] == matrix[row, col + 1]
                        && matrix[row, col] == matrix[row + 1, col]
                        && matrix[row + 1, col] == matrix[row + 1, col + 1];

                    if (isValid == true)
                    {
                        count++;
                    }
                }

            }

            // output
            Console.WriteLine(count);
        }
    }
}
