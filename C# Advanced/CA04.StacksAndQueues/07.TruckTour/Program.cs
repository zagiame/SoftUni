using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            // calculation
            var station = new Queue<string>();
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                station.Enqueue(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                bool isCircle = true;
                int currFluel = 0;

                for (int j = 0; j < n; j++)
                {
                    int[] data = station.Dequeue().Split().Select(int.Parse).ToArray();
                    int fluel = data[0];
                    int distance = data[1];

                    station.Enqueue(string.Join(" ", data));
                    currFluel = currFluel + fluel;
                    currFluel = currFluel - distance;

                    if (currFluel < 0)
                    {
                        isCircle = false;
                    }

                }

                if (isCircle == true)
                {
                    break;
                }

                string tempData = station.Dequeue();
                station.Enqueue(tempData);
                count++;
            }

            // output
            Console.WriteLine(count);

        }
    }
}
