using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int number = int.Parse(Console.ReadLine());

            //calculation
            for (int firstCycle = 0; firstCycle < number; firstCycle++)
            {
                for (int secondCycle = 0; secondCycle < number; secondCycle++)
                {
                    for (int thirdCycle = 0; thirdCycle < number; thirdCycle++)
                    {
                        Console.Write((char)('a' + firstCycle));
                        Console.Write((char)('a' + secondCycle));
                        Console.Write((char)('a' + thirdCycle));
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
