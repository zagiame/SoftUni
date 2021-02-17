using System;

namespace _04._Gifts_from_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            // calculation

            for (int i = m; i >= n; i--)
            {
                if (i % 2 == 0 && i % 3 == 0 && i == s)
                {
                    break;
                }

                else if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.Write($"{i} ");
                }
            }

        }
    }
}
