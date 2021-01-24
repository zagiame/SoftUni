using System;

namespace _04._Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int pages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            // calculation
            double bookTime = pages / pagesPerHour;
            double hoursPerDay = bookTime / days;

            // output
            Console.WriteLine(hoursPerDay);
        }
    }
}
