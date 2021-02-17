using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int number = int.Parse(Console.ReadLine());

            // calculation
            int[] wagoon = new int[number];
            int sum = 0;

            for (int i = 0; i < wagoon.Length; i++)
            {
                wagoon[i] = int.Parse(Console.ReadLine());
                sum = sum + wagoon[i];

            }
            Console.WriteLine(string.Join(' ', wagoon));
            Console.WriteLine(sum);
        }
    }
}
