using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = Console.ReadLine();

            // calculation
            int bestIndex = 0;
            int bestSum = 0;
            int dnaIndexCounter = 0;
            string bestArray = string.Empty;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] dnaCollection = input.Split('!').Select(int.Parse).ToArray();
                // Console.WriteLine($"Array is: {string.Join(' ', dnaCollection)}");

                int currentSum = 0;
                int totalSum = 0;
                dnaIndexCounter++;

                foreach (int item in dnaCollection)
                {
                    totalSum = totalSum + dnaCollection[item];
                    // Console.WriteLine($"Total Sum is: {totalSum}");

                    // Console.WriteLine($"item == {item} || item+1 == {item + 1}");
                    if (dnaCollection[item] == 1 && dnaCollection[item + 1] == 1)
                    {
                        currentSum = currentSum + dnaCollection[item];
                        //Console.WriteLine($"Current Sum is: {currentSum}");
                    }
                }

                if (bestSum < currentSum)
                {
                    bestSum = currentSum;
                    bestIndex = dnaIndexCounter;
                    bestArray = string.Join(' ', dnaCollection);

                    if (bestSum < totalSum)
                    {
                        bestSum = totalSum;
                    }
                }

                // Console.WriteLine($"Best Sum is: {bestSum}");
                // Console.WriteLine($"Best Index is: {bestIndex}");
                // Console.WriteLine($"Best Array is: {bestArray}");
            }

            // output
            Console.WriteLine($"Best DNA sample {bestIndex} with sum: {bestSum}.");
            Console.WriteLine(bestArray);
        }
    }
}

