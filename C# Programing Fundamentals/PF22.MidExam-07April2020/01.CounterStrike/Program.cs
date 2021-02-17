using System;

namespace _01.CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int energy = int.Parse(Console.ReadLine());
            string input = string.Empty;

            // calculation
            int count = 0;

            while ((input = Console.ReadLine()?.ToUpper()) != "END OF BATTLE")
            {
                int distance = int.Parse(input);

                if (distance > energy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {energy} energy");

                    break;
                }

                count++;
                energy = energy - distance;

                if (count % 3 == 0)
                {
                    energy = energy + count;
                }


            }

            // output
            if (input == "END OF BATTLE")
            {
                Console.WriteLine($"Won battles: {count}. Energy left: {energy}");
            }
        }
    }
}
