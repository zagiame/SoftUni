using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int waves = int.Parse(Console.ReadLine());

            // calculation
            List<int> plates = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Stack<int> warriorOrc = new Stack<int>();

            for (int i = 1; i <= waves; i++)
            {
                warriorOrc = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());

                if (i % 3 == 0)
                {
                    int extraPlate = int.Parse(Console.ReadLine());
                    plates.Add(extraPlate);
                }

                while (warriorOrc.Any() && plates.Any())
                {

                    int orc = warriorOrc.Peek();
                    int plate = plates[0];

                    if (orc == plate)
                    {
                        warriorOrc.Pop();
                        plates.Remove(plate);
                    }

                    else if (orc > plate)
                    {
                        warriorOrc.Push(warriorOrc.Pop() - plate);
                        plates.Remove(plate);
                    }

                    else if (orc < plate)
                    {
                        plates[0] -= orc;
                        warriorOrc.Pop();
                    }
                }

                if (plates.Count == 0)
                {
                    break;
                }

            }

            // output

            if (plates.Any())
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }

            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", warriorOrc)}");
            }
        }
    }
}
