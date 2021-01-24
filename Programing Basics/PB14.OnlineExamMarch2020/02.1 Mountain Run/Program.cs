using System;

namespace _02._1_Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double recordInSecounds = double.Parse(Console.ReadLine());
            double distanceInMetric = double.Parse(Console.ReadLine());
            double timeInSecFor1Merter = double.Parse(Console.ReadLine());

            // calculation
            double totalTimeBeforeSlowDown = distanceInMetric * timeInSecFor1Merter;
            double slowDown = Math.Floor(distanceInMetric / 50) * 30;
            double totalTime = totalTimeBeforeSlowDown + slowDown;

            // output
            if (totalTime < recordInSecounds)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
            }

            else
            {
                double timeNeeded = totalTime - recordInSecounds;
                Console.WriteLine($"No! He was {timeNeeded:f2} seconds slower.");
            }
        }
    }
}
