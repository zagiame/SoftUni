using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Loot
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            List<string> chest = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();

            // calculation
            string input = Console.ReadLine();

            while (input?.ToUpper() != "YOHOHO!")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = command[0]?.ToUpper();

                switch (action)
                {
                    ////////////////////////////////////////////////////////////
                    case "LOOT":

                        for (int i = 1; i < command.Length; i++)
                        {
                            if (!chest.Contains(command[i]))
                            {
                                chest.Insert(0, command[i]);
                            }
                        }

                        break;
                    ////////////////////////////////////////////////////////////
                    case "DROP":
                        int index = int.Parse(command[1]);
                        bool isValid = index >= 0 && index < chest.Count;

                        if (isValid)
                        {
                            string removeItem = chest[index];

                            if (chest.Contains(removeItem))
                            {
                                chest.RemoveAt(index);
                                chest.Add(removeItem);
                            }
                        }

                        break;
                    ////////////////////////////////////////////////////////////
                    case "STEAL":
                        int count = int.Parse(command[1]);

                        string stolenItems = StealItems(count, chest);
                        Console.WriteLine(stolenItems);

                        break;
                    ////////////////////////////////////////////////////////////
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            // output
            if (chest.Count != 0)
            {
                double tresureSum = 0;

                for (int i = 0; i < chest.Count; i++)
                {
                    tresureSum = tresureSum + chest[i].Length;
                }

                double averageGain = 1.0 * tresureSum / chest.Count;
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }

            else if (chest.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
        static string StealItems(int count, List<string> chest)
        {
            string result = string.Empty;

            if (count > chest.Count)
            {
                List<string> CaseTaken = chest.Take(chest.Count).ToList();

                for (int i = 0; i < CaseTaken.Count; i++)
                {
                    chest.Remove(CaseTaken[i]);
                }

                result = string.Join(", ", CaseTaken);
                return result;

            }

            List<string> stolen = chest.Skip(Math.Abs(chest.Count - count)).Take(count).ToList();

            for (int i = 0; i < stolen.Count; i++)
            {
                chest.Remove(stolen[i]);
            }

            result = string.Join(", ", stolen);
            return result;
        }
    }
}
