using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int row = int.Parse(Console.ReadLine());

            // calculation
            var parking = new Dictionary<string, string>();

            for (int i = 0; i < row; i++)
            {
                string[] input = Console.ReadLine().Split();
                string action = input[0];
                string userName = input[1];

                if (action == "register")
                {
                    string licensePlateNumber = input[2];

                    if (parking.ContainsKey(userName) == true)
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    else
                    {
                        parking.Add(userName, licensePlateNumber);
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }

                }

                else if (action == "unregister")
                {
                    if (parking.ContainsKey(userName) == false)
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                    }

                    parking.Remove(userName);
                }
            }

            // output
            foreach (var item in parking)
            {
                string name = item.Key;
                string number = item.Value;

                Console.WriteLine($"{name} => {number}");
            }
        }
    }
}
