using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int groupNumber = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            // calculation
            double totalPrice = 0;

            if (groupType == "Students")
            {
                if (day == "Friday")
                {
                    totalPrice = 8.45 * groupNumber;
                }

                else if (day == "Saturday")
                {
                    totalPrice = 9.80 * groupNumber;
                }

                else if (day == "Sunday")
                {
                    totalPrice = 10.46 * groupNumber;
                }

                if (groupNumber >= 30)
                {
                    totalPrice = totalPrice - (totalPrice * 0.15);
                }
            }

            if (groupType == "Business")
            {
                if (groupNumber >= 100)
                {
                    groupNumber = groupNumber - 10;
                }

                if (day == "Friday")
                {
                    totalPrice = 10.90 * groupNumber;
                }

                else if (day == "Saturday")
                {
                    totalPrice = 15.60 * groupNumber;
                }

                else if (day == "Sunday")
                {
                    totalPrice = 16 * groupNumber;
                }

            }

            if (groupType == "Regular")
            {
                if (day == "Friday")
                {
                    totalPrice = 15 * groupNumber;
                }

                else if (day == "Saturday")
                {
                    totalPrice = 20 * groupNumber;
                }

                else if (day == "Sunday")
                {
                    totalPrice = 22.50 * groupNumber;
                }

                if (groupNumber >= 10 && groupNumber <= 20)
                {
                    totalPrice = totalPrice - (totalPrice * 0.05);
                }
            }


            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
