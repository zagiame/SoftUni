using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            // intput
            int n = int.Parse(Console.ReadLine());
            string[] cordinates = Console.ReadLine().Split(',').ToArray();

            // calculation
            var matrix = new char[n, n];
            int firstPlayerShips = 0;
            int secondPlayerShips = 0;

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];

                    if (matrix[row, col] == '<')
                    {
                        firstPlayerShips++;
                    }

                    if (matrix[row, col] == '>')
                    {
                        secondPlayerShips++;
                    }
                }
            }

            // PrintMatrix(matrix);
            int currFirstShip = firstPlayerShips;
            int currSecondShip = secondPlayerShips;


            for (int i = 0; i < cordinates.Length; i++)
            {
                string[] data = cordinates[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int currentRow = int.Parse(data[0]);
                int currentCol = int.Parse(data[1]);

                if (!IsInside(matrix, currentRow, currentCol))
                {
                    continue;
                }

                if (matrix[currentRow, currentCol] == '#')
                {
                    matrix[currentRow, currentCol] = 'X';
                    if (IsInside(matrix, currentRow - 1, currentCol))
                    {
                        if (matrix[currentRow - 1, currentCol] == '<')
                        {
                            firstPlayerShips--;
                        }
                        if (matrix[currentRow - 1, currentCol] == '>')
                        {
                            secondPlayerShips--;
                        }
                        matrix[currentRow - 1, currentCol] = 'X';
                    }
                    if (IsInside(matrix, currentRow + 1, currentCol))
                    {
                        if (matrix[currentRow + 1, currentCol] == '<')
                        {
                            firstPlayerShips--;
                        }
                        if (matrix[currentRow + 1, currentCol] == '>')
                        {
                            secondPlayerShips--;
                        }
                        matrix[currentRow + 1, currentCol] = 'X';
                    }
                    if (IsInside(matrix, currentRow, currentCol - 1))
                    {
                        if (matrix[currentRow, currentCol - 1] == '<')
                        {
                            firstPlayerShips--;
                        }
                        if (matrix[currentRow, currentCol - 1] == '>')
                        {
                            secondPlayerShips--;
                        }
                        matrix[currentRow, currentCol - 1] = 'X';
                    }
                    if (IsInside(matrix, currentRow, currentCol + 1))
                    {
                        if (matrix[currentRow, currentCol + 1] == '<')
                        {
                            firstPlayerShips--;
                        }
                        if (matrix[currentRow, currentCol + 1] == '>')
                        {
                            secondPlayerShips--;
                        }
                        matrix[currentRow, currentCol + 1] = 'X';
                    }
                    if (IsInside(matrix, currentRow - 1, currentCol + 1))
                    {
                        if (matrix[currentRow - 1, currentCol + 1] == '<')
                        {
                            firstPlayerShips--;
                        }
                        if (matrix[currentRow - 1, currentCol + 1] == '>')
                        {
                            secondPlayerShips--;
                        }
                        matrix[currentRow - 1, currentCol + 1] = 'X';
                    }
                    if (IsInside(matrix, currentRow - 1, currentCol - 1))
                    {
                        if (matrix[currentRow - 1, currentCol - 1] == '<')
                        {
                            firstPlayerShips--;
                        }
                        if (matrix[currentRow - 1, currentCol - 1] == '>')
                        {
                            secondPlayerShips--;
                        }
                        matrix[currentRow - 1, currentCol - 1] = 'X';
                    }
                    if (IsInside(matrix, currentRow + 1, currentCol - 1))
                    {
                        if (matrix[currentRow + 1, currentCol - 1] == '<')
                        {
                            firstPlayerShips--;
                        }
                        if (matrix[currentRow + 1, currentCol - 1] == '>')
                        {
                            secondPlayerShips--;
                        }
                        matrix[currentRow + 1, currentCol - 1] = 'X';
                    }
                    if (IsInside(matrix, currentRow + 1, currentCol + 1))
                    {
                        if (matrix[currentRow + 1, currentCol + 1] == '<')
                        {
                            firstPlayerShips--;
                        }
                        if (matrix[currentRow + 1, currentCol + 1] == '>')
                        {
                            secondPlayerShips--;
                        }
                        matrix[currentRow + 1, currentCol + 1] = 'X';
                    }

                    continue;
                }

                if (matrix[currentRow, currentCol] == '<')
                {
                    firstPlayerShips--;
                }

                if (matrix[currentRow, currentCol] == '>')
                {
                    secondPlayerShips--;
                }

                matrix[currentRow, currentCol] = 'X';

                if (firstPlayerShips == 0)
                {
                    Console.WriteLine
                        ($"Player Two has won the game! {currFirstShip + currSecondShip - secondPlayerShips} ships have been sunk in the battle.");
                    break;
                }

                if (secondPlayerShips == 0)
                {
                    Console.WriteLine
                      ($"Player One has won the game! {currSecondShip + (currFirstShip - firstPlayerShips)} ships have been sunk in the battle.");
                    break;
                }
            }

            if (secondPlayerShips != 0 && firstPlayerShips != 0)
            {
                Console.WriteLine($"It's a draw! Player One has {firstPlayerShips} ships left. Player Two has {secondPlayerShips} ships left.");
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }

        private static bool IsInside(char[,] matrix, int currentRow, int currentCol)
        {
            return currentRow >= 0 && currentRow < matrix.GetLength(0) && currentCol >= 0 && currentCol < matrix.GetLength(1);
        }
    }
}

