using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = data[0];
            int m = data[1];

            string name = Console.ReadLine();

            // calculation
            var text = new Queue<char>(name);
            var matrix = new char[n, m];

            for (int row = 0; row < n; row++)
            {

                if (row % 2 == 0)
                {
                    for (int col = 0; col < m; col++)
                    {
                        char current = text.Dequeue();
                        text.Enqueue(current);
                        matrix[row, col] = current;
                    }
                }

                else
                {
                    for (int colOdd = m - 1; colOdd >= 0; colOdd--)
                    {
                        char current = text.Dequeue();
                        text.Enqueue(current);
                        matrix[row, colOdd] = current;
                    }

                }
            }

            // ouput
            PrintMatrix(matrix, n, m);
        }

        public static void PrintMatrix(char[,] matrix, int n, int m)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

    }
}
