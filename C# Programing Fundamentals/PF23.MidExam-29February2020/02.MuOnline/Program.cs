using System;
using System.Linq;

namespace _02.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string[] rooms = Console.ReadLine().Split('|');

            // calculation
            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] command = rooms[i].Split();
                string action = command[0];
                int amount = int.Parse(command[1]);

                if (action == "potion")
                {
                    if (health + amount > 100)
                    {
                        amount = 100 - health;
                    }

                    health = health + amount;
                    Console.WriteLine($"You healed for {amount} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }

                else if (action == "chest")
                {
                    bitcoins = bitcoins + amount;
                    Console.WriteLine($"You found {amount} bitcoins.");
                }

                else
                {
                    string monster = action;
                    int room = i + 1;
                    health = health - amount;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }

                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {room}");
                        break;
                    }
                }
            }

            // output
            if (health > 0)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
