using System;

namespace _9._Volleyball
{
    class Program
    {
        // static data
        static double totalWeekndsPerYear = 48;

        static void Main(string[] args)
        {
            // input
            string yearType = Console.ReadLine();
            int numberHolidays = int.Parse(Console.ReadLine());
            int numberWeekends = int.Parse(Console.ReadLine());

            // calculation
            double weekendsInSofia = totalWeekndsPerYear - numberWeekends;
            double weekendsSofiaPlay = weekendsInSofia * 3.0 / 4.0;
            double holidaysInSofia = numberHolidays * 2.0 / 3.0;

            double plays = holidaysInSofia + weekendsSofiaPlay + numberWeekends;
            
            // output
            if (yearType == "leap")
            {
                plays = plays * 1.15;
                Console.WriteLine($"{Math.Floor(plays)}");
            }

            else
            {
                Console.WriteLine($"{Math.Floor(plays)}");
            }
        }
    }
}
