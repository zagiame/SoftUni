using System;
using System.Linq;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            // intput
            int n = int.Parse(Console.ReadLine());
            string[] move = Console.ReadLine().Split();

            // calculation
            var matrix = new char[n, n];
            int coalCount = 0;
            int mineRow = 0;
            int mineCol = 0;

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];

                    if (matrix[row, col] == 'c')
                    {
                        coalCount++;
                    }

                    if (matrix[row, col] == 's')
                    {
                        mineRow = row;
                        mineCol = col;
                    }
                }
            }

            bool isFound = false;

            foreach (var command in move)
            {
                matrix[mineRow, mineCol] = '*';
                int tempRow = mineRow;
                int tempCol = mineCol;

                mineRow = MoveRow(mineRow, command);
                mineCol = MoveCol(mineCol, command);

                if (IsInsideOfMatrix(mineRow, mineCol, matrix))
                {
                    if (matrix[mineRow, mineCol] == 'c')
                    {
                        coalCount--;

                        if (coalCount == 0)
                        {
                            isFound = true;

                            Console.WriteLine($"You collected all coals! ({mineRow}, {mineCol})");
                            break;
                        }
                    }

                    if (matrix[mineRow, mineCol] == 'e')
                    {
                        isFound = true;

                        Console.WriteLine($"Game over! ({mineRow}, {mineCol})");
                        break;
                    }

                    matrix[mineRow, mineCol] = 's';

                }

                else
                {
                    mineRow = tempRow;
                    mineCol = tempCol;
                }

            }

            // output

            if (isFound == false)
            {
                Console.WriteLine($"{coalCount} coals left. ({mineRow}, {mineCol})");
            }

        }

        private static int MoveRow(int mineRow, string command)
        {

            if (command == "up")
            {
                mineRow = mineRow - 1;
            }

            else if (command == "down")
            {
                mineRow = mineRow + 1;
            }

            return mineRow;
        }

        private static int MoveCol(int mineCol, string command)
        {

            if (command == "left")
            {
                mineCol = mineCol - 1;
            }

            else if (command == "right")
            {
                mineCol = mineCol + 1;
            }

            return mineCol;
        }

        private static bool IsInsideOfMatrix(int mineRow, int mineCol, char[,] matrix)
        {
            return mineRow >= 0 && mineRow < matrix.GetLength(0) && mineCol >= 0 && mineCol < matrix.GetLength(1);
        }

    }
}
