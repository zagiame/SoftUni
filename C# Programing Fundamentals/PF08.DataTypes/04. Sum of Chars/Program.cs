using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int number = int.Parse(Console.ReadLine());

            // calculation
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                char input = char.Parse(Console.ReadLine());
                sum = sum + input ;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
