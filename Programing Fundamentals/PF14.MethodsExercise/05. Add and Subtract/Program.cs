using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            // calculation
            int sum = SumFirstAndSecond(firstNumber, secondNumber);
            int result = Substract(sum, thirdNumber);

            // output
            Console.WriteLine(result);
        }

        private static int Substract(int FirstAndSecond, int thirdNumber)
        {
            int result = FirstAndSecond - thirdNumber;
            return result;

        }

        private static int SumFirstAndSecond(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }
    }
}
