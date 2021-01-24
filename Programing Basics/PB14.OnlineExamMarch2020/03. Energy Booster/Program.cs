using System;

namespace _03._Energy_Booster
{
    class Program
    {
        // static data Samll Pack
        static double watermelonSmall = 56.00;
        static double mangoSmall = 36.66;
        static double pineappleSmall = 42.10;
        static double raspberrySmall = 20.00;

        // static data Big Pack
        static double watermelonBig = 28.70;
        static double mangoBig = 19.60;
        static double pineappleBig = 24.80;
        static double raspberryBig = 15.20;


        static void Main(string[] args)
        {
            // input
            string fruitType = Console.ReadLine();
            string packType = Console.ReadLine();
            double setOrderNumber = double.Parse(Console.ReadLine());

            // calculation
            double setPrice = 0;

            if (packType == "small")
            {
                switch (fruitType)
                {
                    case "Watermelon":
                        setPrice = watermelonSmall * 2;
                        break;

                    case "Mango":
                        setPrice = mangoSmall * 2;
                        break;

                    case "Pineapple":
                        setPrice = pineappleSmall * 2;
                        break;

                    case "Raspberry":
                        setPrice = raspberrySmall * 2;
                        break;
                }
            }

            else if (packType == "big")
            {
                switch (fruitType)
                {
                    case "Watermelon":
                        setPrice = watermelonBig * 5;
                        break;

                    case "Mango":
                        setPrice = mangoBig * 5;
                        break;

                    case "Pineapple":
                        setPrice = pineappleBig * 5;
                        break;

                    case "Raspberry":
                        setPrice = raspberryBig * 5;
                        break;
                }
            }

            double orderSumBeforeDiscount = setPrice * setOrderNumber;
            double discount = 0;
            double finalSum = 0;

            if (400 <= orderSumBeforeDiscount && orderSumBeforeDiscount <= 1000)
            {
                discount = orderSumBeforeDiscount * 0.15;
                finalSum = orderSumBeforeDiscount - discount;
                Console.WriteLine($"{finalSum:f2} lv.");

            }

            else if (orderSumBeforeDiscount > 1000)
            {
                discount = orderSumBeforeDiscount * 0.50;
                finalSum = orderSumBeforeDiscount - discount;
                Console.WriteLine($"{finalSum:f2} lv.");

            }

            else if (orderSumBeforeDiscount < 400)
            {
                finalSum = orderSumBeforeDiscount;
                Console.WriteLine($"{finalSum:f2} lv.");
            }
        }
    }
}
