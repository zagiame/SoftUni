using System;
using System.Linq;

namespace _08.Bombs
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
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            string[] bombData = Console.ReadLine().Split();

            foreach (var item in bombData)
            {
                int[] currentBomb = item.Split(',').Select(int.Parse).ToArray();
                int currentRow = currentBomb[0];
                int currentCol = currentBomb[1];

                Explode(matrix, currentRow, currentCol);
            }

            int aliveCellsCount = 0;
            int aliveCellsSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCellsCount++;
                        aliveCellsSum = aliveCellsSum + matrix[row, col];
                    }
                }
            }

            // output

            Console.WriteLine($"Alive cells: {aliveCellsCount}");
            Console.WriteLine($"Sum: {aliveCellsSum}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }

        }

        private static void Explode(int[,] matrix, int currentRow, int currentCol)
        {
            int power = matrix[currentRow, currentCol];

            if (power > 0)
            {
                matrix[currentRow, currentCol] = 0;

                if (IsInsideOfMatrix(matrix, currentRow - 1, currentCol))
                {
                    int up = matrix[currentRow - 1, currentCol];

                    if (up > 0)
                    {
                        matrix[currentRow - 1, currentCol] -= power;
                    }

                }

                if (IsInsideOfMatrix(matrix, currentRow + 1, currentCol))
                {
                    int down = matrix[currentRow + 1, currentCol];

                    if (down > 0)
                    {
                        matrix[currentRow + 1, currentCol] -= power;
                    }

                }

                if (IsInsideOfMatrix(matrix, currentRow, currentCol - 1))
                {
                    int left = matrix[currentRow, currentCol - 1];

                    if (left > 0)
                    {
                        matrix[currentRow, currentCol - 1] -= power;
                    }

                }

                if (IsInsideOfMatrix(matrix, currentRow, currentCol + 1))
                {
                    int right = matrix[currentRow, currentCol + 1];

                    if (right > 0)
                    {
                        matrix[currentRow, currentCol + 1] -= power;
                    }

                }

                if (IsInsideOfMatrix(matrix, currentRow - 1, currentCol - 1))
                {
                    int upLeft = matrix[currentRow - 1, currentCol - 1];

                    if (upLeft > 0)
                    {
                        matrix[currentRow - 1, currentCol - 1] -= power;
                    }

                }

                if (IsInsideOfMatrix(matrix, currentRow - 1, currentCol + 1))
                {
                    int upRight = matrix[currentRow - 1, currentCol + 1];

                    if (upRight > 0)
                    {
                        matrix[currentRow - 1, currentCol + 1] -= power;
                    }

                }

                if (IsInsideOfMatrix(matrix, currentRow + 1, currentCol - 1))
                {
                    int downLeft = matrix[currentRow + 1, currentCol - 1];

                    if (downLeft > 0)
                    {
                        matrix[currentRow + 1, currentCol - 1] -= power;
                    }

                }

                if (IsInsideOfMatrix(matrix, currentRow + 1, currentCol + 1))
                {
                    int downRight = matrix[currentRow + 1, currentCol + 1];

                    if (downRight > 0)
                    {
                        matrix[currentRow + 1, currentCol + 1] -= power;
                    }

                }
            }

        }

        private static bool IsInsideOfMatrix(int[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
