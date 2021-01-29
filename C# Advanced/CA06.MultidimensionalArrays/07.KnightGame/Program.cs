using System;
using System.Linq;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            // calculation
            var matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int removedKnightsCount = 0;

            while (true)
            {
                int maxAttackedKnigtsCount = 0;
                int knightRow = -1;
                int knightCol = -1;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char symbol = matrix[row, col];

                        if (symbol != 'K')
                        {
                            continue;
                        }

                        int count = GetCountOfAttackedKnights(matrix, row, col);

                        if (count > maxAttackedKnigtsCount)
                        {
                            maxAttackedKnigtsCount = count;
                            knightRow = row;
                            knightCol = col;
                        }

                    }

                }

                if (maxAttackedKnigtsCount == 0)
                {
                    break;
                }

                matrix[knightRow, knightCol] = '0';
                removedKnightsCount++;
            }

            // output

            Console.WriteLine(removedKnightsCount);
        }

        private static int GetCountOfAttackedKnights(char[,] matrix, int row, int col)
        {
            int count = 0;

            if (ContainsKnight(matrix, row - 1, col - 2))
            {
                count++;
            }

            if (ContainsKnight(matrix, row - 1, col + 2))
            {
                count++;
            }

            if (ContainsKnight(matrix, row + 1, col - 2))
            {
                count++;
            }

            if (ContainsKnight(matrix, row + 1, col + 2))
            {
                count++;
            }

            if (ContainsKnight(matrix, row - 2, col - 1))
            {
                count++;
            }

            if (ContainsKnight(matrix, row - 2, col + 1))
            {
                count++;
            }

            if (ContainsKnight(matrix, row + 2, col - 1))
            {
                count++;
            }

            if (ContainsKnight(matrix, row + 2, col + 1))
            {
                count++;
            }

            return count;
        }

        private static bool ContainsKnight(char[,] matrix, int row, int col)
        {
            if (IsValidCell(row, col, matrix.GetLength(0)) == false)
            {
                return false;
            }

            return matrix[row, col] == 'K';
        }

        private static bool IsValidCell(int row, int col, int lenght)
        {
            return row >= 0 && row < lenght && col >= 0 && col < lenght;
        }
    }
}
