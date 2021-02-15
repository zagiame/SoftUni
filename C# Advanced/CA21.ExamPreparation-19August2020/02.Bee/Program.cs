using System;

namespace _02.Bee
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

            // find BEE position
            int beeRow = 0;
            int beeCol = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                        break;
                    }
                }
            }

            // while loop END

            string input = string.Empty;
            int flowerCount = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                matrix[beeRow, beeCol] = '.';
                beeRow = MoveRow(input, beeRow);
                beeCol = MoveCol(input, beeCol);

                if (InsideMatrix(beeRow, beeCol, n, n) == true)
                {

                    if (matrix[beeRow, beeCol] == 'f')
                    {
                        flowerCount++;
                    }

                    else if (matrix[beeRow, beeCol] == 'O')
                    {
                        matrix[beeRow, beeCol] = '.';

                        beeRow = MoveRow(input, beeRow);
                        beeCol = MoveCol(input, beeCol);

                        if (matrix[beeRow, beeCol] == 'f')
                        {
                            flowerCount++;
                        }

                    }

                    matrix[beeRow, beeCol] = 'B';
                }

                else
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }
            }

            // output

            if (flowerCount < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - flowerCount} flowers more");
            }

            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flowerCount} flowers!");
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

        private static bool InsideMatrix(int beeRow, int beeCol, int rowNumber, int colNumber)
        {
            if (beeRow >= 0 && beeRow < rowNumber && beeCol >= 0 && beeCol < colNumber)
            {
                return true;
            }

            return false;

        }

        private static int MoveRow(string input, int row)
        {
            if (input == "up")
            {
                row = row - 1;
            }

            else if (input == "down")
            {
                row = row + 1;
            }

            return row;
        }

        private static int MoveCol(string input, int col)
        {

            if (input == "left")
            {
                col = col - 1;
            }

            else if (input == "right")
            {
                col = col + 1;
            }

            return col;
        }

    }
}
