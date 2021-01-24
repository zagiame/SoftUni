using System;

namespace _08._Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {

            // static data


            // input
            double income = double.Parse(Console.ReadLine());
            double avarageGrade = double.Parse(Console.ReadLine());
            double minimalSelary = double.Parse(Console.ReadLine());

            // calculation
            double scholarshipSocial = Math.Floor(minimalSelary * 0.35);
            double scholarshipExellent = Math.Floor(avarageGrade * 25);

            // output
            if (avarageGrade <= 5.5 && income >= minimalSelary)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            else if (avarageGrade <= 4.5 && income <= minimalSelary)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            else if (avarageGrade <= 5.5 && income <= minimalSelary)
            {
                Console.WriteLine($"You get a Social scholarship {scholarshipSocial} BGN");
            }

            else if (avarageGrade >= 5.5 && income <= minimalSelary && scholarshipSocial >= scholarshipExellent)
            {
                Console.WriteLine($"You get a Social scholarship {scholarshipSocial} BGN");
            }

            else if (avarageGrade >= 5.5 && income <= minimalSelary && scholarshipSocial <= scholarshipExellent)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarshipExellent} BGN");
            }



        }
    }
}
