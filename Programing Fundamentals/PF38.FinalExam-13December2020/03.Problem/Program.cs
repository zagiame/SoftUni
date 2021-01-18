using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = string.Empty;

            // calculation
            var userCollection = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] command = input.Split("->");
                string action = command[0];
                string username = command[1];

                if (action == "Add")
                {
                    if (userCollection.ContainsKey(username) == true)
                    {
                        Console.WriteLine($"{username} is already registered");
                    }

                    else
                    {
                        userCollection.Add(username, new List<string>());
                    }
                }

                else if (action == "Send")
                {
                    string mail = command[2];

                    userCollection[username].Add(mail);
                }

                else if (action == "Delete")
                {
                    if (userCollection.ContainsKey(username) == true)
                    {
                        userCollection.Remove(username);
                    }

                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                }
            }

            // output

            Console.WriteLine($"Users count: {userCollection.Count}");

            foreach (var item in userCollection.OrderByDescending(first => first.Value.Count).ThenBy(second => second.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var mail in item.Value)
                {
                    Console.WriteLine($" - {mail}");
                }
            }

        }
    }
}
