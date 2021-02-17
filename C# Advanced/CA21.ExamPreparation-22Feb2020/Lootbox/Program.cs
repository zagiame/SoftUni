using System;
using System.Collections.Generic;
using System.Linq;

namespace Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            var firstBox = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var secondBox = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            // calculation
            var sumList = new List<int>();

            while (firstBox.Count > 0 && secondBox.Count > 0)
            {
                int sum = 0;
                int n = firstBox.Peek();
                int m = secondBox.Pop();
                sum = n + m;

                if (sum % 2 == 0)
                {
                    sumList.Add(sum);
                    firstBox.Dequeue();
                }

                else
                {
                    firstBox.Enqueue(m);
                }
            }

            // output
            int totalSum = sumList.Sum();

            if (firstBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }

            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (totalSum < 100)
            {
                Console.WriteLine($"Your loot was poor... Value: {totalSum}");
            }

            else
            {
                Console.WriteLine($"Your loot was epic! Value: {totalSum}");
            }
        }
    }
}
