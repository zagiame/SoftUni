using System;
using System.Linq;

namespace _02.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int people = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // calculation

            for (int i = 0; i < lift.Length; i++)
            {
                int currentLoad = 0;

                if (lift[i] < 4)
                {
                    currentLoad = 4 - lift[i];

                    if (currentLoad > people)
                    {
                        currentLoad = people;
                    }

                    lift[i] = lift[i] + currentLoad;
                    people = people - currentLoad;

                }
            }

            // output
            bool isEmpty = people <= 0 && lift.Length * 4 > lift.Sum();

            if (isEmpty)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(' ', lift));
            }

            else if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(' ', lift));
            }

            else
            {
                Console.WriteLine(string.Join(' ', lift));
            }
        }
    }
}
