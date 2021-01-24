using System;
using System.Linq;

namespace _01.BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int studentCount = int.Parse(Console.ReadLine());
            int lectureCount = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());
            int attendanceCount = 0;

            // calculation
            int[] studentAttendance = new int[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                attendanceCount = int.Parse(Console.ReadLine());
                studentAttendance[i] = attendanceCount;
            }

            double bestScore = studentAttendance.Max();
            double totalBonus = bestScore / lectureCount * (5 + bonus);

            // ouput
            Console.WriteLine($"Max Bonus: {Math.Ceiling(totalBonus)}.");
            Console.WriteLine($"The student has attended {bestScore} lectures.");
        }
    }
}
