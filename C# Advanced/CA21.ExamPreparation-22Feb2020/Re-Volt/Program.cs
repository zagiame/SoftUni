using System;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());
            int comandsCount = int.Parse(Console.ReadLine());

            // calculation
            var matrix = new char[n, n];
            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < n; row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];

                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            bool isGameWon = false;

            for (int movement = 0; movement < comandsCount; movement++)
            {
                matrix[playerRow, playerCol] = '-';
                int rowStore = playerRow;
                int colStore = playerCol;

                string command = Console.ReadLine();
                playerRow = MoveRow(playerRow, command, n);
                playerCol = MoveCol(playerCol, command, n);

                if (matrix[playerRow, playerCol] == 'F')
                {
                    matrix[playerRow, playerCol] = 'f';
                    isGameWon = true;
                    break;
                }

                else if (matrix[playerRow, playerCol] == 'B')
                {
                    playerRow = MoveRow(playerRow, command, n);
                    playerCol = MoveCol(playerCol, command, n);
                }

                else if (matrix[playerRow, playerCol] == 'T')
                {
                    playerRow = rowStore;
                    playerCol = colStore;
                }

                matrix[playerRow, playerCol] = 'f';
            }

            // ouput

            if (isGameWon == true)
            {
                Console.WriteLine("Player won!");
            }

            else
            {
                Console.WriteLine("Player lost!");
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static int MoveRow(int playerRow, string command, int totalRow)
        {
            if (command == "up")
            {
                playerRow = playerRow - 1;
            }

            else if (command == "down")
            {
                playerRow = playerRow + 1;
            }

            if (playerRow < 0)
            {
                playerRow = totalRow - 1;
            }

            if (playerRow == totalRow)
            {
                playerRow = 0;
            }

            return playerRow;
        }

        private static int MoveCol(int playerCol, string command, int totalCol)
        {
            if (command == "left")
            {
                playerCol = playerCol - 1;
            }

            else if (command == "right")
            {
                playerCol = playerCol + 1;
            }

            if (playerCol < 0)
            {
                playerCol = totalCol - 1;
            }

            if (playerCol == totalCol)
            {
                playerCol = 0;
            }

            return playerCol;
        }

    }
}
