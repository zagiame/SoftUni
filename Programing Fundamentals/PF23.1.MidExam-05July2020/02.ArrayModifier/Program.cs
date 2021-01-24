using System;
using System.Linq;

namespace _02.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //calculation
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "decrease")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = array[i] - 1;
                    }
                }

                else
                {
                    string[] command = input.Split();
                    string action = command[0];
                    int firstIndex = int.Parse(command[1]);
                    int secondIndex = int.Parse(command[2]);

                    if (action == "swap")
                    {
                        int swap = array[firstIndex];
                        array[firstIndex] = array[secondIndex];
                        array[secondIndex] = swap;

                    }

                    else if (action == "multiply")
                    {
                        array[firstIndex] = array[firstIndex] * array[secondIndex];
                    }

                }
            }

            // output
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
