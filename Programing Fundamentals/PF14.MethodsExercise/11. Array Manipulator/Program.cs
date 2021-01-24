using System;
using System.ComponentModel.Design;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string[] input = Console.ReadLine().Split().ToArray();
            string command = Console.ReadLine();

            while (command != "end")
            {
                int index = 0;

                if (command == $"exchance {index}")
                {
                    Exchange(input, index);
                }

                command = Console.ReadLine();
            }

        }

        private static void Exchange(string[] input, int index)
        {
            string[] firstArray = input.Take(index).ToArray();
            string[] secondArray = input.Skip(index).ToArray();
        }

    }
}
