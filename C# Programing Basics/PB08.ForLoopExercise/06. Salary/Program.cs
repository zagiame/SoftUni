using System;

namespace _06._Salary
{
    class Program
    {
        static double facebook = 150;
        static double instagram = 100;
        static double reddit = 50;

        static void Main(string[] args)
        {
            int tabsOpen = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            double pageFacebook = 0;
            double pageInstagram = 0;
            double pageReddit = 0;

            for (int i = 0; i < tabsOpen; i++)
            {
                string pageName = Console.ReadLine();

                if (pageName == "Facebook")
                {
                    salary = salary - facebook;
                }

                if (pageName == "Instagram")
                {
                    salary = salary - instagram;
                }

                if (pageName == "Reddit")
                {
                    salary = salary - reddit;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }

            }

            if (salary > 0)
            {
                Console.WriteLine(salary);
            }

        }
    }
}
