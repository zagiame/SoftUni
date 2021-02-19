using System;
using System.Linq;
using System.Text;

namespace ParkingFeud
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int samEntrance = int.Parse(Console.ReadLine());

            // calculation
            int numberOfRows = dimensions[0] * 2 - 1;
            int numberOfCols = dimensions[1] + 2;
            int nemberOfEntrance = numberOfRows - 1;

            // create matrix
            var matrix = new string[numberOfRows, numberOfCols];
            int entranceCount = 1;

            for (int row = 0; row < numberOfRows; row++)
            {
                for (int col = 0; col < numberOfCols; col++)
                {

                    if (col == 0 || col == numberOfCols - 1 || row % 2 == 1)
                    {
                        if (col == 0 && row % 2 == 1)
                        {
                            matrix[row, col] = "*" + entranceCount++;
                        }

                        else
                        {
                            matrix[row, col] = ".";
                        }
                    }

                    else
                    {
                        matrix[row, col] = NameOfMatrix(row, col);
                    }
                }
            }

            // print test
            // PrintMatrix(matrix);

            bool isParked = false;
            int totalDistance = 0;

            while (isParked == false)
            {
                string[] lots = Console.ReadLine().Split();
                string parkingSpot = lots[samEntrance - 1];
                int[] lotToParkData = FindLotToParkData(parkingSpot);

                if (IsInsideOfMatrix(lotToParkData, matrix) == false)
                {
                    continue;
                }

                int carCount = 0;
                int carOneEntranceIndex = 0;
                int carTwoEntranceIndex = 0;

                for (int i = 0; i < lots.Length; i++)
                {
                    if (lots[i] == parkingSpot)
                    {
                        if (carCount == 0)
                        {
                            carOneEntranceIndex = i + 1;
                            carCount++;
                        }

                        else if (carCount != 0)
                        {
                            carTwoEntranceIndex = i + 1;
                            carCount++;
                        }
                    }
                }

                if (carCount == 1)
                {

                    totalDistance = totalDistance + GetDistance(matrix, lotToParkData, carOneEntranceIndex);

                    isParked = true;
                    Console.WriteLine($"Parked successfully at {parkingSpot}.");
                    Console.WriteLine($"Total Distance Passed: {totalDistance}");

                }

                else if (carCount == 2)
                {

                    int carOneDistance = GetDistance(matrix, lotToParkData, carOneEntranceIndex);
                    int carTwoDistance = GetDistance(matrix, lotToParkData, carTwoEntranceIndex);

                    int indexSamCar = 0;
                    int samDistance = 0;

                    // find Sam Car

                    if (carOneEntranceIndex == samEntrance)
                    {
                        indexSamCar = carOneEntranceIndex;
                        samDistance = carOneDistance;
                    }

                    else if (carTwoEntranceIndex == samEntrance)
                    {
                        indexSamCar = carTwoEntranceIndex;
                        samDistance = carTwoDistance;
                    }

                    // is Found?

                    if (carOneDistance < carTwoDistance && indexSamCar == carOneEntranceIndex ||
                        carOneDistance > carTwoDistance && indexSamCar == carTwoEntranceIndex)
                    {

                        totalDistance += samDistance;
                        isParked = true;

                        Console.WriteLine($"Parked successfully at {parkingSpot}.");
                        Console.WriteLine($"Total Distance Passed: {totalDistance}");

                    }

                    else
                    {
                        totalDistance += samDistance * 2;
                        isParked = false;
                    }
                }

            }

        }

        private static bool IsInsideOfMatrix(int[] lotToParkData, string[,] matrix)
        {
            return lotToParkData[0] >= 0 && lotToParkData[0] < matrix.GetLength(0) && lotToParkData[1] >= 0 && lotToParkData[1] < matrix.GetLength(1);
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static int GetDistance(string[,] matrix, int[] lotToParkData, int carEntranceIndex)
        {
            int distance = 0;
            int carRow = FindStartRow(matrix, carEntranceIndex);
            int carCol = 0;

            int lotToParkRow = lotToParkData[0];
            int lotToParkCol = lotToParkData[1];

            bool isDestinationFound = false;
            bool goLeft = false;

            while (isDestinationFound == false)
            {

                if (goLeft == false && isDestinationFound == false)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        carCol += 1;
                        distance++;

                        if (matrix[carRow + 1, carCol] == matrix[lotToParkRow, lotToParkCol] ||
                            matrix[carRow - 1, carCol] == matrix[lotToParkRow, lotToParkCol])
                        {
                            isDestinationFound = true;
                            break;
                        }
                    }
                }

                if (carRow < lotToParkRow - 1 && carCol == 0 ||
                    carRow < lotToParkRow + 1 && carCol == matrix.GetLength(1) - 1)
                {
                    carRow = carRow + 2;
                    distance += 2;
                }

                else if (carRow > lotToParkRow - 1 && carCol == 0 ||
                         carRow > lotToParkRow + 1 && carCol == matrix.GetLength(1) - 1)
                {
                    carRow = carRow - 2;
                    distance += 2;
                }

                goLeft = !goLeft;

                if (goLeft == true && isDestinationFound == false)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        carCol -= 1;
                        distance++;

                        if (matrix[carRow + 1, carCol] == matrix[lotToParkRow, lotToParkCol] ||
                            matrix[carRow - 1, carCol] == matrix[lotToParkRow, lotToParkCol])
                        {
                            isDestinationFound = true;
                            break;
                        }
                    }
                }
            }

            return distance;
        }

        private static int FindStartRow(string[,] matrix, int samEntrance)
        {
            int samRow = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, 0] == "*" + samEntrance)
                {
                    samRow = row;
                    break;
                }
            }

            return samRow;
        }

        private static int[] FindLotToParkData(string parkingSpot)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char rowChar = parkingSpot.FirstOrDefault();

            int row = (int.Parse(parkingSpot.Substring(1)) - 1) * 2;
            int column = alphabet.IndexOf(rowChar) + 1;

            return new int[] { row, column };

        }



        private static string NameOfMatrix(int row, int col)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int getIndex = row / 2;

            return alphabet.Substring(getIndex, 1) + col;
        }
    }
}

