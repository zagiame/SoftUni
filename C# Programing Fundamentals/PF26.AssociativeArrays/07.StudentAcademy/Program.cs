using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int row = int.Parse(Console.ReadLine());

            // calculation
            var list = new Dictionary<string, List<double>>();

            for (int i = 0; i < row; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (list.ContainsKey(student) == false)
                {
                    list.Add(student, new List<double>());
                }

                list[student].Add(grade);
            }

            foreach (var item in list)
            {
                if (item.Value.Average() < 4.50)
                {
                    list.Remove(item.Key);
                }
            }

            // output

            foreach (var item in list.OrderByDescending(first => first.Value.Average()))
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }
        }
    }
}
