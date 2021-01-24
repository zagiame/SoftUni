using System;

namespace _04._1_Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double numberOfGroups = double.Parse(Console.ReadLine());

            // calculation
            double totalParticipants = 0;
            double group1 = 0;
            double group2 = 0;
            double group3 = 0;
            double group4 = 0;
            double group5 = 0;

            for (int i = 0; i < numberOfGroups; i++)
            {
                double peopleInGroup = double.Parse(Console.ReadLine());

                if (peopleInGroup <= 5)
                {
                    group1 = group1 + peopleInGroup;
                }

                else if (peopleInGroup <= 12)
                {
                    group2 = group2 + peopleInGroup;
                }

                else if (peopleInGroup <= 25)
                {
                    group3 = group3 + peopleInGroup;
                }

                else if (peopleInGroup <= 40)
                {
                    group4 = group4 + peopleInGroup;
                }

                else if (peopleInGroup >= 41)
                {
                    group5 = group5 + peopleInGroup;
                }

                totalParticipants = totalParticipants + peopleInGroup;
            }

            double percentGroup1 = group1 / totalParticipants * 100;
            double percentGroup2 = group2 / totalParticipants * 100;
            double percentGroup3 = group3 / totalParticipants * 100;
            double percentGroup4 = group4 / totalParticipants * 100;
            double percentGroup5 = group5 / totalParticipants * 100;

            // output
            Console.WriteLine($"{percentGroup1:f2}%");
            Console.WriteLine($"{percentGroup2:f2}%");
            Console.WriteLine($"{percentGroup3:f2}%");
            Console.WriteLine($"{percentGroup4:f2}%");
            Console.WriteLine($"{percentGroup5:f2}%");
        }
    }
}
