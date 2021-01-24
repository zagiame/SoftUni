using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int commands = int.Parse(Console.ReadLine());

            // calculation
            List<string> guests = new List<string>();

            for (int i = 0; i < commands; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];

                if (input.Length > 3)
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }

                else
                {
                    if (!guests.Contains(name))
                    {
                        guests.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
            }

            // output
            Console.WriteLine(string.Join(Environment.NewLine, guests));
        }
    }
}

