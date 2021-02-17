using System;

namespace _01._Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string name = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());
            double score = double.Parse(Console.ReadLine());

            // ouput
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {score:f2}");

        }
    }
}
