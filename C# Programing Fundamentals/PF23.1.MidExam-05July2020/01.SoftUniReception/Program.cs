using System;

namespace _01.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int fisrtEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());

            // calculation
            int efficiencyPerHour = fisrtEmployee + secondEmployee + thirdEmployee;
            int timeNeeded = 0;

            while (peopleCount > 0)
            {
                timeNeeded++;
                peopleCount = peopleCount - efficiencyPerHour;

                if (timeNeeded % 4 == 0)
                {
                    timeNeeded++;
                }
            }

            // output
            Console.WriteLine($"Time needed: {timeNeeded}h.");
        }
    }
}
