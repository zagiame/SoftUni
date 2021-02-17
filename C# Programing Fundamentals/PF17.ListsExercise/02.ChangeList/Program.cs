using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            // calculation
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] currentInput = input.Split();
                int element = int.Parse(currentInput[1]);

                if (currentInput[0] == "Delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers.Remove(element);
                    }
                }

                else if (currentInput[0] == "Insert")
                {
                    int position = int.Parse(currentInput[2]);
                    numbers.Insert(position, element);
                }

                input = Console.ReadLine();
            }

            // output
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
