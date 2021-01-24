using System;

namespace _01._Change_Bureau
{
    class Program
    {
        // static data
        static double bitCoin = 1168;
        static double uan = 0.15 * 1.76;
        static double usd = 1.76;
        static double euro = 1.95;

        static void Main(string[] args)
        {
            // input
            double bitCoinTotal = double.Parse(Console.ReadLine());
            double chineseUanTotal = double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());

            // calculation
            double convertedBitcoin = bitCoinTotal * bitCoin;
            double convertedUan = chineseUanTotal * uan;
            double totalMoneyBGN = convertedBitcoin + convertedUan;
            double totalMoneyEuro = totalMoneyBGN / euro;
            double comisionTotal = totalMoneyEuro * comision / 100;
            double total = totalMoneyEuro - comisionTotal;

            // output
            Console.WriteLine($"{total:f2}");
        }
    }
}
