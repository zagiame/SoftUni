using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            // calculation
            double result = GetFactorial(firstNumber) / GetFactorial(secondNumber);

            // output
            Console.WriteLine($"{result:f2}");
        }

        public static double GetFactorial(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
    }
}
