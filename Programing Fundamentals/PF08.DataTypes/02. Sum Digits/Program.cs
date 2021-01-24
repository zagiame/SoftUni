using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string number = Console.ReadLine();

            // calculation

            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int currentNumber = int.Parse(number[i].ToString());
                sum = sum + currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
