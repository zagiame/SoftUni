using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            // calculation
            int difference = 0;
            int hours = 0;
            int minutes = 0;
            examMinutes = examMinutes + examHour * 60;
            arriveMinutes = arriveMinutes + arriveHour * 60;

            // output
            if (arriveMinutes > examMinutes)
            {
                Console.WriteLine("Late");
                difference = arriveMinutes - examMinutes;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hours = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                }
            }

            else if (arriveMinutes < examMinutes - 30)
            {
                Console.WriteLine("Early");
                difference = examMinutes - arriveMinutes;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hours = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
            }

            else if (arriveMinutes == examMinutes)
            {
                Console.WriteLine("On time");
            }

            else
            {
                difference = examMinutes - arriveMinutes;
                Console.WriteLine("On time");
                Console.WriteLine($"{difference} minutes before the start");
            }
        }
    }
}
