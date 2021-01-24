using System;
using System.Runtime.ConstrainedExecution;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double deposit = double.Parse(Console.ReadLine());
            int depositDue = int.Parse(Console.ReadLine());
            double yearInterest = double.Parse(Console.ReadLine());

            // calculation
            double interestAmaount = (deposit * yearInterest) / 100;
            double interestPerMonth = interestAmaount / 12;
            double totalSum = deposit + depositDue * interestPerMonth;

            // output
            Console.WriteLine(totalSum);
        }
    }
}
