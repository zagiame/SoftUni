using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            // static data


            // input
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            // calculation
            minutes += 15;
            if (minutes >= 60)
            {
                minutes -= 60;
                hours += 1;
            }
            if (hours >= 24)
            {
                hours = 0;
            }

            // output
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
