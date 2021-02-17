using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            // calculation
            var matrix = new char[n, n];
            int snakeRow = 0;
            int snakeCol = 0;
            int burrowOneRow = 0;
            int burrowOneCol = 0;
            int burrowTwoRow = 0;
            int burrowTwoCol = 0;
            int burrowCount = 0;

            for (int row = 0; row < n; row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];

                    if (rowData[col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }

                    if (rowData[col] == 'B' && burrowCount == 0)
                    {
                        burrowOneRow = row;
                        burrowOneCol = col;
                        burrowCount++;
                    }

                    if (rowData[col] == 'B' && burrowCount != 0)
                    {
                        burrowTwoRow = row;
                        burrowTwoCol = col;
                    }
                }
            }

            int foodCount = 0;

            while (foodCount != 10)
            {
                matrix[snakeRow, snakeCol] = '.';

                string input = Console.ReadLine();
                snakeRow = MoveRow(snakeRow, input);
                snakeCol = MoveCol(snakeCol, input);

                if (IsInsideOfMatrix(snakeRow, snakeCol, n, n) == true)
                {
                    if (matrix[snakeRow, snakeCol] == '*')
                    {
                        foodCount++;
                    }

                    else if (matrix[snakeRow, snakeCol] == 'B')
                    {
                        matrix[snakeRow, snakeCol] = '.';

                        if (snakeRow == burrowOneRow && snakeCol == burrowOneCol)
                        {
                            snakeRow = burrowTwoRow;
                            snakeCol = burrowTwoCol;
                        }

                        else
                        {
                            snakeRow = burrowOneRow;
                            snakeCol = burrowOneCol;
                        }
                    }

                    matrix[snakeRow, snakeCol] = 'S';
                }

                else
                {
                    Console.WriteLine("Game over!");
                    break;
                }
            }

            // output

            if (foodCount == 10)
            {
                Console.WriteLine("You won! You fed the snake.");
            }

            Console.WriteLine($"Food eaten: {foodCount}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static bool IsInsideOfMatrix(int snakeRow, int snakeCol, int totalRow, int totalCol)
        {
            return (snakeRow >= 0 && snakeRow < totalRow && snakeCol >= 0 && snakeCol < totalCol);
        }

        private static int MoveRow(int snakeRow, string input)
        {
            if (input == "up")
            {
                snakeRow = snakeRow - 1;
            }

            else if (input == "down")
            {
                snakeRow = snakeRow + 1;
            }

            return snakeRow;
        }

        private static int MoveCol(int snakeCol, string input)
        {
            if (input == "left")
            {
                snakeCol = snakeCol - 1;
            }

            else if (input == "right")
            {
                snakeCol = snakeCol + 1;
            }

            return snakeCol;
        }

    }
}
