using System;
using System.Linq;

namespace _02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = string.Empty;

            // calculation
            int count = 0;

            while ((input = Console.ReadLine()?.ToUpper()) != "END")
            {
                int index = int.Parse(input);
                int currentTarget = 0;

                if (index < 0 || index >= targets.Length || targets[index] == -1)
                {
                    continue;
                }

                count++;
                currentTarget = targets[index];
                targets[index] = -1;

                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] == -1)
                    {
                        continue;
                    }

                    if (currentTarget < targets[i])
                    {
                        targets[i] = targets[i] - currentTarget;
                    }

                    else
                    {
                        targets[i] = targets[i] + currentTarget;
                    }
                }
            }

            // output
            Console.WriteLine($"Shot targets: {count} -> {string.Join(' ', targets)}");
        }
    }
}
