using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            // calculation
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] currentInput = input.Split();

                if (currentInput[0] == "Add")
                {
                    wagons.Add(int.Parse(currentInput[1]));
                }

                else
                {
                    int passangers = int.Parse(currentInput[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        bool isFree = wagons[i] + passangers <= capacity;

                        if (isFree)
                        {
                            wagons[i] = wagons[i] + passangers;
                            break;
                        }

                    }
                }

                input = Console.ReadLine();
            }

            // output
            Console.WriteLine(string.Join(' ', wagons));

        }
    }
}
