using System;
using System.Runtime;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int poorGradeLimit = int.Parse(Console.ReadLine());

            // calculation
            string task = Console.ReadLine();
            int poorGradeCounter = 0;
            int gradeCounter = 0;
            int score = 0;
            bool isPerfect = true;
            string lastProblem = "";

            while (task != "Enough")
            {

                lastProblem = task;
                int grade = int.Parse(Console.ReadLine());
                gradeCounter++;
                score = score + grade;

                if (grade <= 4)
                {
                    poorGradeCounter++;

                    if (poorGradeCounter >= poorGradeLimit)
                    {
                        isPerfect = false;
                        break;
                    }
                }

                task = Console.ReadLine();

            }

            double averageScore = 1.0 * score / gradeCounter;

            // output
            if (isPerfect == true)
            {
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {gradeCounter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }

            else
            {
                Console.WriteLine($"You need a break, {poorGradeLimit} poor grades.");
            }
        }
    }
}
