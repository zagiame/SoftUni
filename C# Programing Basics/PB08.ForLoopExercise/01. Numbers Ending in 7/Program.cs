﻿using System;

namespace _01._Numbers_Ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 0; number <= 1000; number++)
            {
                if (number % 10 == 7)
                {
                    Console.WriteLine(number);
                }    
            }
        }
    }
}
