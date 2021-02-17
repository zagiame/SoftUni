using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            List<string> grocery = Console.ReadLine().Split('!').ToList();

            // calculation
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] commnad = input.Split();
                string action = commnad[0];
                string item = commnad[1];
                bool isThere = true;
                bool isMissing = false;
                int index = grocery.IndexOf(item);

                switch (action)
                {
                    ////////////////////////////////////////////////////////////
                    case "Urgent":
                        if (isThere == grocery.Contains(item))
                        {
                            continue;
                        }

                        grocery.Insert(0, item);
                        break;
                    ////////////////////////////////////////////////////////////
                    case "Unnecessary":
                        if (isMissing == grocery.Contains(item))
                        {
                            continue;
                        }

                        grocery.Remove(item);
                        break;
                    ////////////////////////////////////////////////////////////
                    case "Correct":
                        string oldName = item;
                        string newName = commnad[2];

                        if (isMissing == grocery.Contains(item))
                        {
                            continue;
                        }

                        grocery.RemoveAt(index);
                        grocery.Insert(index, newName);
                        break;
                    ////////////////////////////////////////////////////////////
                    case "Rearrange":
                        if (isMissing == grocery.Contains(item))
                        {
                            continue;
                        }

                        grocery.RemoveAt(index);
                        grocery.Add(item);
                        break;
                    ////////////////////////////////////////////////////////////
                    default:
                        break;
                }

            }


            Console.WriteLine(string.Join(", ", grocery));
        }
    }
}
