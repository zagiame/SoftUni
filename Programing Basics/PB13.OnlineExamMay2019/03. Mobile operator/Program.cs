using System;

namespace _03._Mobile_operator
{
    class Program
    {
        // static data 1 Year
        static double oneSmall = 9.98;
        static double oneMiddle = 18.99;
        static double oneLarge = 25.98;
        static double oneExtraLarge = 35.99;

        // static data 2 Year
        static double twoSmall = 8.58;
        static double twoMiddle = 17.09;
        static double twoLarge = 23.59;
        static double twoExtraLarge = 31.79;

        // static data Internet Option
        static double internetOptionLessThan10 = 5.50;
        static double internetOptionLessThan30 = 4.35;
        static double internetOptionMoreThan30 = 3.85;

        static void Main(string[] args)
        {
            // input
            string contractDuration = Console.ReadLine();
            string contractType = Console.ReadLine();
            string internetOption = Console.ReadLine();
            double monthCount = double.Parse(Console.ReadLine());

            // calculation
            double monthPrice = 0;
            double internetPrice = 0;
            double totalPrice = 0;

            if (contractDuration == "one")
            {
                switch (contractType)
                {
                    case "Small":
                        monthPrice = oneSmall;
                        break;

                    case "Middle":
                        monthPrice = oneMiddle;
                        break;

                    case "Large":
                        monthPrice = oneLarge;
                        break;

                    case "ExtraLarge":
                        monthPrice = oneExtraLarge;
                        break;
                }
            }

            else if (contractDuration == "two")
            {
                switch (contractType)
                {
                    case "Small":
                        monthPrice = twoSmall;
                        break;

                    case "Middle":
                        monthPrice = twoMiddle;
                        break;

                    case "Large":
                        monthPrice = twoLarge;
                        break;

                    case "ExtraLarge":
                        monthPrice = twoExtraLarge;
                        break;
                }
            }

            if (internetOption == "yes")
            {

                if (monthPrice <= 10)
                {
                    internetPrice = internetOptionLessThan10;
                }

                else if (monthPrice <= 30)
                {
                    internetPrice = internetOptionLessThan30;
                }

                else if (monthPrice > 30)
                {
                    internetPrice = internetOptionMoreThan30;
                }

                monthPrice = monthPrice + internetPrice;

            }

            if (contractDuration == "two")
            {
                monthPrice = monthPrice - (monthPrice * 0.0375);
            }

            totalPrice = monthPrice * monthCount;
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
