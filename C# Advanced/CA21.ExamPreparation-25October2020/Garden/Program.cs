using System;
using System.Collections.Generic;

namespace Garden
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
            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = 0;
                }
            }

            // position to plant
            string input = string.Empty;
            var plants = new List<string>();

            while ((input = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                string[] inputData = input.Split();
                int currentRow = int.Parse(inputData[0]);
                int currentCol = int.Parse(inputData[1]);

                if (IndexIsInsideOfMatrix(currentRow, currentCol, n, m) == true)
                {
                    matrix[currentRow, currentCol] = 1;
                    string flower = $"{currentRow} {currentCol}";
                    plants.Add(flower);
                }

                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }
            }

            // bloom

            foreach (var item in plants)
            {
                Bloom(item, matrix);
            }


            // output
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }

        private static void Bloom(string item, int[,] matrix)
        {
            string[] rowData = item.Split();
            int currentRow = int.Parse(rowData[0]);
            int currentCol = int.Parse(rowData[1]);
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            // bloom up
            for (int up = 1; up < n; up++)
            {
                if (IndexIsInsideOfMatrix(currentRow - up, currentCol, n, m) == true)
                {
                    matrix[currentRow - up, currentCol]++;
                }

                else
                {
                    break;
                }

            }

            // bloom down
            for (int down = 1; down < n; down++)
            {
                if (IndexIsInsideOfMatrix(currentRow + down, currentCol, n, m) == true)
                {
                    matrix[currentRow + down, currentCol]++;
                }

                else
                {
                    break;
                }

            }

            // bloom left
            for (int left = 1; left < m; left++)
            {
                if (IndexIsInsideOfMatrix(currentRow, currentCol - left, n, m) == true)
                {
                    matrix[currentRow, currentCol - left]++;
                }

                else
                {
                    break;
                }

            }

            // bloom right
            for (int right = 1; right < m; right++)
            {
                if (IndexIsInsideOfMatrix(currentRow, currentCol + right, n, m) == true)
                {
                    matrix[currentRow, currentCol + right]++;
                }

                else
                {
                    break;
                }

            }

        }

        private static bool IndexIsInsideOfMatrix(int currentRow, int currentCol, int totalRow, int totalCol)
        {
            if (currentRow >= 0 && currentRow < totalRow && currentCol >= 0 && currentCol < totalCol)
            {
                return true;
            }

            return false;
        }
    }
}
