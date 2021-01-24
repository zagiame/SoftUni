using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {

            // static data


            // input
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            // calculation
            double distanceInSeconds = distanceInMeters * timeInSeconds;
            double delay = Math.Floor(distanceInMeters / 15) * 12.5;
            double finalTime = distanceInSeconds + delay;
            double needTime = finalTime - recordInSeconds;

            // output
            if (finalTime < recordInSeconds)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {needTime:f2} seconds slower.");
            }
        }
    }
}
