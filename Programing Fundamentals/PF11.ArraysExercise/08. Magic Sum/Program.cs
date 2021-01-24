﻿using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] input = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();

            int number = int.Parse(Console.ReadLine());

            // calculation
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (number == input[i] + input[j])
                    {
                        Console.WriteLine($"{input[i]} {input[j]}");
                        break;
                    }
                }
            }

        }
    }
}
