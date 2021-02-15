using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            var lilies = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            var roses = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));

            // calculation
            int count = 0;
            int flowersLeft = 0;

            while (lilies.Count > 0 && roses.Count > 0)
            {
                int currentLilie = lilies.Pop();
                int currentRose = roses.Dequeue();
                int sum = currentLilie + currentRose;

                if (sum == 15)
                {
                    count++;
                }

                else if (sum < 15)
                {
                    flowersLeft = flowersLeft + sum;
                }

                else if (sum % 2 == 1)
                {
                    count++;
                }

                else
                {
                    flowersLeft = flowersLeft + 14;
                }
            }

            count = count + flowersLeft / 15;

            // output

            if (count < 5)
            {
                Console.WriteLine($"You didn't make it, you need {5 - count} wreaths more!");
            }

            else
            {
                Console.WriteLine($"You made it, you are going to the competition with {count} wreaths!");
            }
        }
    }
}
