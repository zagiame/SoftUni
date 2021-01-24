using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            // static price
            double cake = 45;
            double waffel = 5.8;
            double pancake = 3.2;

            // input
            int dateDuration = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int sumCake = int.Parse(Console.ReadLine());
            int sumWaffel = int.Parse(Console.ReadLine());
            int sumPancake = int.Parse(Console.ReadLine());

            // calculation
            double sumPerDay = (sumCake * cake + sumPancake * pancake + sumWaffel * waffel) * bakers;
            double sumCampaign = sumPerDay * dateDuration;
            double totalEarnings = sumCampaign - (sumCampaign * 1 / 8);

            // output
            Console.WriteLine(totalEarnings);
        }
    }
}
