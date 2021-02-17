using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            // calculation
            int counter = 0;

            while (people > 0 && people != 0)
            {
                people = people - capacity;
                counter++;
            }

            // output
            Console.WriteLine(counter);
        }
    }
}
