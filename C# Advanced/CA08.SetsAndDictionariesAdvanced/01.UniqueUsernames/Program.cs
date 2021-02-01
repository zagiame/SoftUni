using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int number = int.Parse(Console.ReadLine());

            // calculation
            var usernames = new HashSet<string>();

            for (int i = 0; i < number; i++)
            {
                usernames.Add(Console.ReadLine());
            }

            // output

            foreach (var item in usernames)
            {
                Console.WriteLine(item);
            }

        }
    }
}
