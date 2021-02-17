using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            var bombEffect = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            var bombCasing = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));

            // calculation
            var bombCollection = new Dictionary<string, int>();
            bombCollection.Add("Datura Bombs", 0);
            bombCollection.Add("Cherry Bombs", 0);
            bombCollection.Add("Smoke Decoy Bombs", 0);

            bool isSuccessfullyFilled = false;

            while (bombEffect.Count > 0 && bombCasing.Count > 0)
            {
                int sum = 0;
                int currentEffect = bombEffect.Peek();
                int currentCasing = bombCasing.Peek();
                sum = currentEffect + currentCasing;

                if (sum == 40)
                {
                    bombCollection["Datura Bombs"]++;
                    bombEffect.Dequeue();
                    bombCasing.Pop();
                }

                else if (sum == 60)
                {
                    bombCollection["Cherry Bombs"]++;
                    bombEffect.Dequeue();
                    bombCasing.Pop();
                }

                else if (sum == 120)
                {
                    bombCollection["Smoke Decoy Bombs"]++;
                    bombEffect.Dequeue();
                    bombCasing.Pop();
                }

                else
                {
                    bombCasing.Pop();
                    currentCasing = currentCasing - 5;
                    bombCasing.Push(currentCasing);
                }

                if (IsSuccessfullyFilled(bombCollection) == true)
                {
                    isSuccessfullyFilled = true;
                    break;
                }
            }

            // output

            if (isSuccessfullyFilled)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }

            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffect.Count > 0)
            {
                Console.WriteLine("Bomb Effects: " + string.Join(", ", bombEffect));
            }

            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (bombCasing.Count > 0)
            {
                Console.WriteLine("Bomb Casings: " + string.Join(", ", bombCasing));
            }

            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            foreach (var item in bombCollection.OrderBy(first => first.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static bool IsSuccessfullyFilled(Dictionary<string, int> bombCollection)
        {
            bool isValid = bombCollection["Datura Bombs"] >= 3 &&
                bombCollection["Cherry Bombs"] >= 3 &&
                bombCollection["Smoke Decoy Bombs"] >= 3;

            return isValid;
        }
    }
}
