using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = string.Empty;

            // calculation
            var set = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] command = input.Split();
                string action = command[1];
                string userOne = command[0];
                string userTwo = command[2];

                if (action == "joined")
                {
                    if (set.ContainsKey(userOne) == false)
                    {
                        set.Add(userOne, new Dictionary<string, SortedSet<string>>());
                        set[userOne].Add("followers", new SortedSet<string>());
                        set[userOne].Add("following", new SortedSet<string>());
                    }
                }

                else if (action == "followed")
                {
                    bool isValid = set.ContainsKey(userOne) == true
                                   && set.ContainsKey(userTwo) == true
                                   && userOne != userTwo;

                    if (isValid == true)
                    {
                        set[userOne]["following"].Add(userTwo);
                        set[userTwo]["followers"].Add(userOne);
                    }
                }
            }

            // output

            Console.WriteLine($"The V-Logger has a total of {set.Count} vloggers in its logs.");
            int count = 0;

            foreach (var item in set.OrderByDescending(first => first.Value["followers"].Count)
                .ThenBy(second => second.Value["following"].Count))
            {
                count++;
                string user = item.Key;
                int following = set[user]["following"].Count();
                int followers = set[user]["followers"].Count();


                Console.WriteLine($"{count}. {user} : {followers} followers, {following} following");

                if (count == 1)
                {
                    foreach (var pair in set[user]["followers"])
                    {
                        Console.WriteLine($"*  {pair}");
                    }
                }
            }
        }
    }
}
