using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double number = double.Parse(Console.ReadLine());
            string inputMetric = Console.ReadLine();
            string outputMetric = Console.ReadLine();

            // calculation
            if (inputMetric == "mm" && outputMetric == "cm")
            {
                number /= 10;
            }
            else if (inputMetric == "mm" && outputMetric == "m")
            {
                number /= 1000;
            }
            else if (inputMetric == "cm" && outputMetric == "m")
            {
                number /= 100;
            }
            else if (inputMetric == "cm" && outputMetric == "mm")
            {
                number *= 10;
            }
            else if (inputMetric == "m" && outputMetric == "cm")
            {
                number *= 100;
            }
            else if (inputMetric == "m" && outputMetric == "mm")
            {
                number *= 1000;
            }

            // output
            Console.WriteLine($"{number:f3}");

        }
    }
}
