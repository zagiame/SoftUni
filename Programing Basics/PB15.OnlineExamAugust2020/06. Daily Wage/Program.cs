using System;

namespace _06._Daily_Wage
{
    class Program
    {
        //static data
        static double strawberryPrice = 3.50;
        static double blueberryPrice = 5.00;

        static void Main(string[] args)
        {
            // input
            int row = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            // calculation
            int rowCounter = 0;
            int strawberryCounter = 0;
            int blueberryCounter = 0;

            for (int r = 0; r < row; r++)
            {
                rowCounter++;
                int positionCounter = 0;

                if (rowCounter % 2 != 0)
                {
                    for (int i = 0; i < position; i++)
                    {
                        strawberryCounter++;
                    }
                }

                else if (rowCounter % 2 == 0)
                {
                    for (int p = 0; p < position; p++)
                    {
                        positionCounter++;

                        if (positionCounter % 3 != 0)
                        {
                            blueberryCounter++;
                        }

                    }
                }

            }

            double totalPriceBeforeSelling = strawberryCounter * strawberryPrice + blueberryCounter * blueberryPrice;
            double totalPrice = 0.80 * totalPriceBeforeSelling;
            // output
            Console.WriteLine($"Total: {totalPrice:f2} lv.");
        }
    }
}
