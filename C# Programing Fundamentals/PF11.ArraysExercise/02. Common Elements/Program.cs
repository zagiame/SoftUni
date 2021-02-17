using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string[] input1 = Console.ReadLine().Split(" ");
            string[] input2 = Console.ReadLine().Split(" ");

            // calculation

            foreach (string item in input2)
            {
                for (int i = 0; i < input1.Length; i++)
                {
                    if (item == input1[i])
                    {
                        Console.Write($"{item} ");
                    }
                }
            }
        }
    }
}
