using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            var bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            var locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int jobValue = int.Parse(Console.ReadLine());

            // calculate
            int currentBarrel = gunBarrelSize;
            int bulletsCount = 0;

            while (bullets.Count > 0 && locks.Count > 0)
            {
                int currentBullet = bullets.Pop();
                int currentLock = locks.Peek();
                currentBarrel--;
                bulletsCount++;

                if (currentBullet <= currentLock)
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }

                else
                {
                    Console.WriteLine("Ping!");
                }

                if (bullets.Count > 0 && currentBarrel == 0)
                {
                    Console.WriteLine("Reloading!");
                    currentBarrel = gunBarrelSize;
                }
            }

            // output

            if (bullets.Count == 0 && locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }

            else
            {
                int bulletsLeft = bullets.Count;
                int moneyEarned = jobValue - bulletsCount * bulletPrice;

                Console.WriteLine($"{bulletsLeft} bullets left. Earned ${moneyEarned}");
            }
        }
    }
}
