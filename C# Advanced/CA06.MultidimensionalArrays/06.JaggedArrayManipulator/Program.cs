using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            // calculation
            var matrix = new double[n][];

            for (int row = 0; row < n; row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[row] = new double[rowData.Length];

                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row][col] = rowData[col];
                }
            }

            // analyzing matrix

            for (int row = 0; row < n - 1; row++)
            {
                double[] firstArray = matrix[row];
                double[] secondArray = matrix[row + 1];

                if (firstArray.Length == secondArray.Length)
                {
                    matrix[row] = firstArray.Select(e => e * 2).ToArray();
                    matrix[row + 1] = secondArray.Select(e => e * 2).ToArray();
                }

                else
                {
                    matrix[row] = firstArray.Select(e => e / 2).ToArray();
                    matrix[row + 1] = secondArray.Select(e => e / 2).ToArray();
                }

            }

            // matrix operations

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                string action = command[0];
                int rowIndex = int.Parse(command[1]);
                int colIndex = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                bool isValid = rowIndex >= 0 && rowIndex < n && colIndex >= 0 && colIndex < matrix[rowIndex].Length;

                if (isValid == true)
                {

                    if (action == "Add")
                    {
                        matrix[rowIndex][colIndex] = matrix[rowIndex][colIndex] + value;
                    }

                    else if (action == "Subtract")
                    {
                        matrix[rowIndex][colIndex] = matrix[rowIndex][colIndex] - value;
                    }

                }
            }

            // output

            for (int row = 0; row < n; row++)
            {

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
