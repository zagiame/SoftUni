using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            // calculation
            double expenses = headsetPrice * (lostGames / 2);
            expenses = expenses + (mousePrice * (lostGames / 3));
            expenses = expenses + (keyboardPrice * (lostGames / 6));
            expenses = expenses + (displayPrice * (lostGames / 12));

            // output
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");

        }
    }
}
