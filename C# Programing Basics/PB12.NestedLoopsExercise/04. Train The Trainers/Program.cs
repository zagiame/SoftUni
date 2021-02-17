using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int judgeNumber = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            // calculation
            int gradeCounter = 0;
            double sumOfAllGrades = 0;

            while (input != "Finish")
            {
                double gradeSum = 0;

                for (int i = 0; i < judgeNumber; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradeSum = gradeSum + grade;
                    gradeCounter++;
                    sumOfAllGrades = sumOfAllGrades + grade;
                }

                double averageGradeOfSinglePresentation = gradeSum / judgeNumber;
                Console.WriteLine($"{input} - {averageGradeOfSinglePresentation:f2}.");
                input = Console.ReadLine();

            }

            double averageSumOfAllGrades = sumOfAllGrades / gradeCounter;
            Console.WriteLine($"Student's final assessment is {averageSumOfAllGrades:f2}.");

        }
    }
}
