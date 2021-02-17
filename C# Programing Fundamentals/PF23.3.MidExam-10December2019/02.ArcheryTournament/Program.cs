using System;
using System.Linq;

namespace _02.ArcheryTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] target = Console.ReadLine().Split('|').Select(int.Parse).ToArray();

            // calculation
            string input = string.Empty;
            int points = 0;

            while ((input = Console.ReadLine()) != "Game over")
            {
                if (input == "Reverse")
                {
                    for (int i = 0; i < target.Length / 2; i++)
                    {
                        int tmp = target[i];
                        target[i] = target[target.Length - i - 1];
                        target[target.Length - i - 1] = tmp;
                    }

                    continue;
                }

                string[] command = input.Split('@');
                string action = command[0];
                int startIndex = int.Parse(command[1]);
                int length = int.Parse(command[2]);

                if (startIndex < 0 || startIndex >= target.Length)
                {
                    continue;
                }

                if (action == "Shoot Left")
                {
                    int currentIndex = startIndex - length;

                    if (currentIndex < 0 || currentIndex >= target.Length)
                    {
                        for (int i = length - 1; i >= 0; i--)
                        {
                            currentIndex = currentIndex - 1;

                            if (currentIndex < 0 || currentIndex >= target.Length)
                            {
                                currentIndex = target.Length - 1;
                            }

                        }
                    }

                    if (target[currentIndex] == 0)
                    {
                        continue;
                    }

                    else if (target[currentIndex] < 5)
                    {
                        points = points + target[currentIndex];
                        target[currentIndex] = 0;
                    }

                    else
                    {
                        points = points + 5;
                        target[currentIndex] = target[currentIndex] - 5;
                    }

                }

                else if (action == "Shoot Right")
                {
                    int currentIndex = startIndex + length;

                    if (currentIndex < 0 || currentIndex >= target.Length)
                    {
                        for (int i = 0; i < length; i++)
                        {
                            currentIndex = currentIndex + 1;

                            if (currentIndex < 0 || currentIndex >= target.Length)
                            {
                                currentIndex = 0;
                            }

                        }
                    }

                    if (target[currentIndex] == 0)
                    {
                        continue;
                    }

                    else if (target[currentIndex] < 5)
                    {
                        points = points + target[currentIndex];
                        target[currentIndex] = 0;
                    }

                    else
                    {
                        points = points + 5;
                        target[currentIndex] = target[currentIndex] - 5;
                    }
                }
            }

            // output
            Console.WriteLine(string.Join(" - ", target));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");

        }
    }
}
