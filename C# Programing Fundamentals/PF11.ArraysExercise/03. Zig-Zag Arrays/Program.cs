using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int number = int.Parse(Console.ReadLine());

            // calculation
            string[] input1 = new string[number];
            string[] input2 = new string[number];

            for (int i = 0; i < number; i++)
            {
                string[] currentArray = Console.ReadLine()
                                                .Split()
                                                .ToArray();

                string elementZero = currentArray[0];
                string elementOne = currentArray[1];

                if (i % 2 == 0)
                {
                    input1[i] = elementZero;
                    input2[i] = elementOne;
                }
                else if (i % 2 == 1)
                {
                    input1[i] = elementOne;
                    input2[i] = elementZero;
                }
            }
            Console.WriteLine(string.Join(' ', input1));
            Console.WriteLine(string.Join(' ', input2));
        }
    }
}
