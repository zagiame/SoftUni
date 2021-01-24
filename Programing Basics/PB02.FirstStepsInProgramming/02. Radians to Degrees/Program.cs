using System;

namespace _02._Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double radians = double.Parse(Console.ReadLine());
            // calculation
            double degrees = radians * 180 / Math.PI;
            // output
            Console.WriteLine(Math.Round(degrees));

        }
    }
}
