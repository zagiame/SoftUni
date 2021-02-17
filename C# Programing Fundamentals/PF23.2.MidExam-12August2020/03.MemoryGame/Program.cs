using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            List<string> game = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            // calculation
            string input = string.Empty;
            int moveCount = 0;

            while ((input = Console.ReadLine()) != "end" && game.Count > 0)
            {
                moveCount++;
                string[] commnad = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int firstIndex = int.Parse(commnad[0]);
                int secondIndex = int.Parse(commnad[1]);
                bool isValid = firstIndex != secondIndex
                            && firstIndex >= 0
                            && firstIndex < game.Count
                            && secondIndex >= 0
                            && secondIndex < game.Count;

                if (!isValid)
                {
                    string insertElement = $"-{moveCount}a";
                    int insertIndex = game.Count / 2;
                    game.Insert(insertIndex, insertElement);
                    game.Insert(insertIndex, insertElement);

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }

                else if (game[firstIndex] == game[secondIndex])
                {
                    string element = game[firstIndex];

                    Console.WriteLine($"Congrats! You have found matching elements - {element}!");

                    game.RemoveAll(x => x == element);
                }

                else
                {
                    Console.WriteLine("Try again!");
                }

            }

            // ouput
            if (input == "end")
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(' ', game));
            }

            else if (game.Count == 0)
            {
                Console.WriteLine($"You have won in {moveCount} turns!");
            }
        }
    }
}
