using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = string.Empty;

            // calculation

            while ((input = Console.ReadLine()?.ToUpper()) != "END")
            {
                string[] command = input.Split();
                string action = command[0]?.ToUpper();
                int index = int.Parse(command[1]);
                int value = int.Parse(command[2]);

                switch (action)
                {
                    //////////////////////////////////////////////////////////////
                    case "SHOOT":

                        int power = value;

                        if (index < 0 || index >= targets.Count)
                        {
                            continue;
                        }

                        targets[index] = targets[index] - power;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }

                        break;
                    //////////////////////////////////////////////////////////////
                    case "ADD":

                        if (index < 0 || index >= targets.Count)
                        {
                            Console.WriteLine("Invalid placement!");
                            continue;
                        }

                        targets.Insert(index, value);
                        break;
                    //////////////////////////////////////////////////////////////
                    case "STRIKE":

                        int radius = value;

                        if (index < 0
                            || index >= targets.Count
                            || index - radius < 0
                            || index + radius >= targets.Count)
                        {
                            Console.WriteLine("Strike missed!");
                            continue;
                        }

                        targets.RemoveRange(index - radius, (radius * 2) + 1);
                        break;
                    //////////////////////////////////////////////////////////////

                    default:
                        break;
                }

            }

            // output
            Console.WriteLine(string.Join('|', targets));
        }
    }
}
