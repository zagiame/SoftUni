using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int songNumber = int.Parse(Console.ReadLine());

            // calculation
            var composerCollection = new Dictionary<string, string>();
            var keyCollection = new Dictionary<string, string>();

            for (int i = 0; i < songNumber; i++)
            {
                string[] command = Console.ReadLine().Split('|');
                string piece = command[0];
                string composer = command[1];
                string key = command[2];

                composerCollection.Add(piece, composer);
                keyCollection.Add(piece, key);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] command = input.Split('|');
                string action = command[0];
                string piece = command[1];

                if (action == "Add")
                {
                    string composer = command[2];
                    string key = command[3];

                    if (composerCollection.ContainsKey(piece) == true)
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }

                    else
                    {
                        composerCollection.Add(piece, composer);
                        keyCollection.Add(piece, key);

                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }

                }

                else if (action == "Remove")
                {
                    if (composerCollection.ContainsKey(piece) == true)
                    {
                        composerCollection.Remove(piece);
                        keyCollection.Remove(piece);

                        Console.WriteLine($"Successfully removed {piece}!");
                    }

                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

                else if (action == "ChangeKey")
                {
                    string newKey = command[2];

                    if (composerCollection.ContainsKey(piece) == true)
                    {
                        keyCollection[piece] = newKey;

                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }

                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }

            // output

            foreach (var item in composerCollection.OrderBy(first => first.Key).ThenBy(second => second.Value))
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value}, Key: {keyCollection[item.Key]}");
            }

        }
    }
}
