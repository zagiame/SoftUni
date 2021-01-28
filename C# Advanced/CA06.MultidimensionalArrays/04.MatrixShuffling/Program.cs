using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = data[0];
            int m = data[1];

            // calculation
            var matrix = new string[n, m];

            for (int row = 0; row < n; row++)
            {
                string[] input = Console.ReadLine().Split();

                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] currentInput = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = currentInput[0];

                if (action == "swap" && currentInput.Length == 5)
                {
                    int rowOne = int.Parse(currentInput[1]);
                    int colOne = int.Parse(currentInput[2]);
                    int rowTwo = int.Parse(currentInput[3]);
                    int colTwo = int.Parse(currentInput[4]);

                    bool isValid = rowOne < n && rowTwo < n && colOne < m && colTwo < m;

                    if (isValid == true)
                    {
                        string temp = matrix[rowOne, colOne];
                        matrix[rowOne, colOne] = matrix[rowTwo, colTwo];
                        matrix[rowTwo, colTwo] = temp;

                        PrintMatrix(matrix, n, m);
                    }

                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }

                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

        }

        public static void PrintMatrix(string[,] matrix, int n, int m)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
