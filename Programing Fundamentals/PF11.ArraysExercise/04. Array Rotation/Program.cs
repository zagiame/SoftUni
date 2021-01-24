using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string[] input = Console.ReadLine().Split();
            int number = int.Parse(Console.ReadLine());

            // calculation
            for (int i = 0; i < number; i++)
            {
                string firstInput = input[0];

                for (int j = 1; j < input.Length; j++)
                {
                    string currentInput = input[j];
                    input[j - 1] = currentInput;
                }

                input[input.Length - 1] = firstInput;
            }

            // output
            Console.WriteLine(string.Join(' ', input));
        }
    }
}
