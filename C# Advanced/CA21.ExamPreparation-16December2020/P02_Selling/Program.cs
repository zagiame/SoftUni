using System;

namespace P02_Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            // calculation
            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            // find start position S and pillats O
            int startRow = 0;
            int startCol = 0;
            int pillarOneRow = 0;
            int pillarOneCol = 0;
            int pillarTwoRow = 0;
            int pillarTwoCol = 0;
            int pillarCount = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        startRow = row;
                        startCol = col;
                    }

                    if (matrix[row, col] == 'O' && pillarCount == 0)
                    {
                        pillarOneRow = row;
                        pillarOneCol = col;
                        pillarCount++;
                    }

                    if (matrix[row, col] == 'O' && pillarCount != 0)
                    {
                        pillarTwoRow = row;
                        pillarTwoCol = col;
                    }
                }
            }

            // start movement
            string input = string.Empty;
            int money = 0;

            while ((input = Console.ReadLine()) != "End" && money < 50)
            {
                matrix[startRow, startCol] = '-';
                startRow = MoveRow(input, startRow);
                startCol = MoveCol(input, startCol);

                if (IsInsideOfMatrix(startRow, startCol, n, n) == true)
                {
                    if (Char.IsDigit(matrix[startRow, startCol]) == true)
                    {
                        int currentValue = int.Parse(matrix[startRow, startCol].ToString());
                        money = money + currentValue;
                    }

                    else if (matrix[startRow, startCol] == 'O')
                    {
                        if (startRow == pillarOneRow && startCol == pillarOneCol)
                        {
                            matrix[pillarOneRow, pillarOneCol] = '-';
                            startRow = pillarTwoRow;
                            startCol = pillarTwoCol;
                        }

                        else
                        {
                            matrix[pillarTwoRow, pillarTwoCol] = '-';
                            startRow = pillarOneRow;
                            startCol = pillarOneCol;
                        }
                    }

                    matrix[startRow, startCol] = 'S';
                }

                else
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    break;
                }
            }

            // output

            if (money >= 50)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }

            Console.WriteLine($"Money: {money}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static bool IsInsideOfMatrix(int startRow, int startCol, int totalRow, int totalCol)
        {
            if (startRow >= 0 && startRow < totalRow && startCol >= 0 && startCol < totalCol)
            {
                return true;
            }

            return false;
        }

        private static int MoveRow(string input, int startRow)
        {
            if (input == "up")
            {
                startRow = startRow - 1;
            }

            else if (input == "down")
            {
                startRow = startRow + 1;
            }

            return startRow;
        }

        private static int MoveCol(string input, int startCol)
        {
            if (input == "left")
            {
                startCol = startCol - 1;
            }

            else if (input == "right")
            {
                startCol = startCol + 1;
            }

            return startCol;
        }
    }
}
