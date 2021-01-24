using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            // calculation
            minutes = minutes + 30;

            if (minutes > 59)
            {
                hour = hour + 1;
                minutes = minutes - 60;
            }

            if (hour > 23)
            {
                hour = hour - 24;
            }

            // output
            Console.WriteLine($"{hour}:{minutes:d2}");
        }
    }
}
