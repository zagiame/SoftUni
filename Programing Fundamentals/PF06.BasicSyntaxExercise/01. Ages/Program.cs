using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int age = int.Parse(Console.ReadLine());

            // calculation
            string type = string.Empty;

            if (age >= 0 && age <= 2)
            {
                type = "baby";
            }

            if (age >= 3 && age <= 13)
            {
                type = "child";
            }

            if (age >= 14 && age <= 19)
            {
                type = "teenager";
            }

            if (age >= 20 && age <= 65)
            {
                type = "adult";
            }

            if (age >= 66)
            {
                type = "elder";
            }

            // output
            Console.WriteLine(type);
        }
    }
}
