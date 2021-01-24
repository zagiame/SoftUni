using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string[] input = Console.ReadLine().Split('\\');

            // calculation
            string[] output = input[input.Length - 1].Split('.');

            // output
            Console.WriteLine($"File name: {output[0]}");
            Console.WriteLine($"File extension: {output[1]}");
        }
    }
}
