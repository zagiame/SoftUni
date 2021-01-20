using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string[] startSongs = Console.ReadLine().Split(", ");

            // calculation
            var songs = new Queue<string>(startSongs);

            while (songs.Any() == true)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                string action = input[0];

                if (action == "Play")
                {
                    songs.Dequeue();
                }

                else if (action == "Add")
                {
                    input.Remove(action);
                    string name = string.Join(" ", input);

                    if (songs.Contains(name) == true)
                    {
                        Console.WriteLine($"{name} is already contained!");
                    }

                    else
                    {
                        songs.Enqueue(name);
                    }
                }

                else
                {
                    if (songs.Any() == true)
                    {
                        Console.WriteLine(string.Join(", ", songs));
                    }
                }
            }

            // output
            Console.WriteLine("No more songs!");
        }
    }
}
