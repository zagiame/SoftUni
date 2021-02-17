using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = Console.ReadLine();

            // calculation
            var SB = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length - 1)
                {
                    SB.Append(input[i]);
                }

                else if (input[i] != input[i + 1])
                {
                    SB.Append(input[i]);
                }
            }

            // output
            Console.WriteLine(SB.ToString());
        }
    }
}
