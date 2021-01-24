using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = string.Empty;

            // calculation
            var force = new Dictionary<string, string>();

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] join = input.Split(" | ");
                string[] change = input.Split(" -> ");

                if (input.Contains('|'))
                {
                    string side = join[0];
                    string user = join[1];

                    if (force.ContainsKey(user) == false)
                    {
                        force.Add(user, side);
                    }

                }

                else if (input.Contains("->") == true)
                {
                    string user = change[0];
                    string side = change[1];

                    if (force.ContainsKey(user) == false)
                    {
                        force.Add(user, side);
                    }

                    else
                    {
                        force[user] = side;
                    }

                    Console.WriteLine($"{user} joins the {side} side!");

                }
            }

            // NEW COLLECTION
            var output = new Dictionary<string, List<string>>();

            foreach (var item in force)
            {
                string user = item.Key;
                string side = item.Value;

                if (output.ContainsKey(side) == false)
                {
                    output.Add(side, new List<string>());
                }

                output[side].Add(user);
            }

            // output
            foreach (var item in output.OrderByDescending(first => first.Value.Count).ThenBy(second => second.Key))
            {
                string side = item.Key;
                int members = item.Value.Count();

                Console.WriteLine($"Side: {side}, Members: {members}");

                foreach (var user in output[side].OrderBy(name => name))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
