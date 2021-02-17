using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //calculation
            double cakeSize = x * y;
            double cakePieces = 0;

            while (cakeSize > 0)
            {
                string operation = Console.ReadLine();

                if (operation == "STOP")
                {
                    Console.WriteLine($"{cakeSize} pieces are left.");
                    break;
                }

                else
                {
                    cakePieces = double.Parse(operation);
                    cakeSize = cakeSize - cakePieces;

                    if (cakeSize < 0)
                    {
                        Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
                        break;
                    }
                }


            }

        }
    }
}
