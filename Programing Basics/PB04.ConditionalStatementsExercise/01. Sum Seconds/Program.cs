using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            // static data


            // input
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            // calculation
            int totalTime = firstTime + secondTime + thirdTime;
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            // output
            Console.WriteLine($"{minutes}:{seconds:d2}");
        }
    }
}
