using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string[] matrixData = Console.ReadLine().Split();
            int n = int.Parse(matrixData[0]);
            int m = int.Parse(matrixData[1]);

            // calculation
            var matrix = new char[n, m];
            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < n; row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = rowData[col];

                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }

                }
            }

            var moves = Console.ReadLine().ToLower();

            foreach (char direction in moves)
            {
                switch (direction)
                {
                    case 'u':
                        MoveUp(matrix, playerRow, playerCol);
                        playerRow--;
                        if (Populate(ref matrix, playerRow, playerCol))
                        {
                            Die(matrix, playerRow, playerCol);
                        }
                        break;
                    case 'd':
                        MoveDown(matrix, playerRow, playerCol);
                        playerRow++;
                        if (Populate(ref matrix, playerRow, playerCol))
                        {
                            Die(matrix, playerRow, playerCol);
                        }
                        break;
                    case 'l':
                        MoveLeft(matrix, playerRow, playerCol);
                        playerCol--;
                        if (Populate(ref matrix, playerRow, playerCol))
                        {
                            Die(matrix, playerRow, playerCol);
                        }
                        break;
                    case 'r':
                        MoveRight(matrix, playerRow, playerCol);
                        playerCol++;
                        if (Populate(ref matrix, playerRow, playerCol))
                        {
                            Die(matrix, playerRow, playerCol);
                        }
                        break;
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////
        private static void MoveUp(char[,] matrix, int currentRow, int currentCol)
        {
            matrix[currentRow, currentCol] = '.';

            if (currentRow == 0)
            {
                Populate(ref matrix, currentRow, currentCol);

                Win(matrix, currentRow, currentCol);
            }
            else
            {
                if (matrix[currentRow - 1, currentCol] == 'B')
                {
                    Populate(ref matrix, currentRow, currentCol);

                    Die(matrix, currentRow - 1, currentCol);
                }
                else
                {
                    matrix[currentRow - 1, currentCol] = 'P';
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////
        private static void MoveDown(char[,] matrix, int currentRow, int currentCol)
        {
            matrix[currentRow, currentCol] = '.';

            if (currentRow == matrix.GetLength(0) - 1)
            {
                Populate(ref matrix, currentRow, currentCol);

                Win(matrix, currentRow, currentCol);
            }
            else
            {
                if (matrix[currentRow + 1, currentCol] == 'B')
                {
                    Populate(ref matrix, currentRow, currentCol);

                    Die(matrix, currentRow + 1, currentCol);
                }
                else
                {
                    matrix[currentRow + 1, currentCol] = 'P';
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////
        private static void MoveRight(char[,] matrix, int currentRow, int currentCol)
        {
            matrix[currentRow, currentCol] = '.';

            if (currentCol == matrix.GetLength(1) - 1)
            {
                Populate(ref matrix, currentRow, currentCol);
                Win(matrix, currentRow, currentCol);
            }
            else
            {
                if (matrix[currentRow, currentCol + 1] == 'B')
                {
                    Populate(ref matrix, currentRow, currentCol);
                    Die(matrix, currentRow, currentCol + 1);
                }
                else
                {
                    matrix[currentRow, currentCol + 1] = 'P';
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////
        private static void MoveLeft(char[,] matrix, int currentRow, int currentCol)
        {
            matrix[currentRow, currentCol] = '.';

            if (currentCol == 0)
            {
                Populate(ref matrix, currentRow, currentCol);

                Win(matrix, currentRow, currentCol);
            }
            else
            {
                if (matrix[currentRow, currentCol - 1] == 'B')
                {
                    Populate(ref matrix, currentRow, currentCol);

                    Die(matrix, currentRow, currentCol - 1);
                }
                else
                {
                    matrix[currentRow, currentCol - 1] = 'P';
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////
        private static bool Populate(ref char[,] matrix, int currentRow, int currentCol)
        {
            char[,] result = new char[matrix.GetLength(0), matrix.GetLength(1)];
            Array.Copy(matrix, result, matrix.Length);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i > 0 && matrix[i, j] == 'B')
                    {
                        result[i - 1, j] = 'B';
                    }

                    if (i < matrix.GetLength(0) - 1 && matrix[i, j] == 'B')
                    {
                        result[i + 1, j] = 'B';
                    }

                    if (j > 0 && matrix[i, j] == 'B')
                    {
                        result[i, j - 1] = 'B';
                    }

                    if (j < matrix.GetLength(1) - 1 && matrix[i, j] == 'B')
                    {
                        result[i, j + 1] = 'B';
                    }
                }
            }

            bool isDead = true;

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    if (result[i, j] == 'P')
                    {
                        isDead = false;
                    }
                }
            }

            matrix = result;

            return isDead;
        }

        ///////////////////////////////////////////////////////////////////////////////////
        private static void Die(char[,] matrix, int currentRow, int currentCol)
        {
            Print(matrix);
            Console.WriteLine($"dead: {currentRow} {currentCol}");
            Environment.Exit(0);
        }

        ///////////////////////////////////////////////////////////////////////////////////
        private static void Win(char[,] matrix, int currentRow, int currentCol)
        {
            Print(matrix);
            Console.WriteLine($"won: {currentRow} {currentCol}");
            Environment.Exit(0);
        }

        ///////////////////////////////////////////////////////////////////////////////////
        private static void Print(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}