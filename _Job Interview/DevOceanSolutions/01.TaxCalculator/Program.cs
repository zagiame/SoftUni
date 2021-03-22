using System;

namespace _01.TaxCalculator
{
    class Program
    {
        static double maxSalaryWithoutTax = 1000;
        static double maxSalarySocialContribution = 3000;
        static double taxPercentange = 0.10;
        static double socialPercentange = 0.15;

        static void Main(string[] args)
        {
            string input = string.Empty;
            Console.WriteLine("input your salary");

            while ((input = Console.ReadLine()).ToLower() != "end")
            {

                double salary;
                bool isValidInput =
                    double.TryParse(input, out salary) &&
                    double.Parse(input) >= 0;

                if (isValidInput)
                {
                    salary = double.Parse(input);
                    double tax = 0;
                    double socialContribution = 0;

                    if (salary > maxSalaryWithoutTax)
                    {
                        tax = (salary - maxSalaryWithoutTax) * taxPercentange;
                        socialContribution = (salary - maxSalaryWithoutTax) * socialPercentange;

                        if (salary > maxSalarySocialContribution)
                        {
                            socialContribution = (maxSalarySocialContribution - maxSalaryWithoutTax) * socialPercentange;
                        }
                    }

                    salary = salary - tax - socialContribution;
                    double totalTax = tax + socialContribution;

                    Console.WriteLine($"net worth: {salary:f2} IDR");
                    Console.WriteLine($"tax: {tax:f2} IDR");
                    Console.WriteLine($"social contribution: {socialContribution:f2} IDR");
                    Console.WriteLine($"total tax: {totalTax:f2} IDR");
                }

                else
                {
                    Console.WriteLine("invalid input");
                    Console.WriteLine("valid input is of numeric type higher than 0");
                }

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("continue with next input or type \"end\" to quit");
                Console.WriteLine();
            }

            /*
             
            leaving comments;
            console application with while loop untill receiving command "END";
            using statics for easy access and correction throughout the code;
            problem is too short for initialising methods;

             */
        }
    }
}

