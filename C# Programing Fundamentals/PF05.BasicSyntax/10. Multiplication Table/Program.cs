using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            // intput
            int number = int.Parse(Console.ReadLine());

            // calculation

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }

        }
    }
}
