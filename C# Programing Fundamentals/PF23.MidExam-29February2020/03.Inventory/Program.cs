using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            List<string> inventory = Console.ReadLine().Split(", ").ToList();

            // calculation
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] command = input.Split(" - ");
                string action = command[0];
                string item = command[1];


                switch (action)
                {
                    /////////////////////////////////////////////////////
                    case "Collect":

                        if (!inventory.Contains(item))
                        {
                            inventory.Add(item);
                        }

                        break;
                    /////////////////////////////////////////////////////
                    case "Drop":

                        inventory.Remove(item);

                        break;
                    /////////////////////////////////////////////////////
                    case "Combine Items":
                        string[] combineItem = item.Split(':');
                        string oldItem = combineItem[0];
                        string newItem = combineItem[1];

                        if (inventory.Contains(oldItem))
                        {
                            int index = 1 + inventory.IndexOf(oldItem);
                            inventory.Insert(index, newItem);
                        }

                        break;
                    /////////////////////////////////////////////////////
                    case "Renew":

                        if (inventory.Contains(item))
                        {
                            inventory.Remove(item);
                            inventory.Add(item);
                        }

                        break;
                    /////////////////////////////////////////////////////
                    default:
                        break;
                }

            }

            // output
            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
