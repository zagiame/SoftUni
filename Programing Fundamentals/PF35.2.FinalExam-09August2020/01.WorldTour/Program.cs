using System;

namespace _01.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string plan = Console.ReadLine();

            // calculation
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Travel")
            {
                string[] commnad = input.Split(':');
                string action = commnad[0];

                if (action == "Add Stop")
                {
                    int index = int.Parse(commnad[1]);
                    string add = commnad[2];

                    if (IsValid(index, plan) == true)
                    {
                        plan = plan.Insert(index, add);
                    }

                }

                else if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(commnad[1]);
                    int endIndex = int.Parse(commnad[2]);
                    int count = endIndex - startIndex + 1;
                    bool valid = IsValid(startIndex, plan) == true && IsValid(endIndex, plan) == true;

                    if (valid == true && count + startIndex <= plan.Length)
                    {
                        plan = plan.Remove(startIndex, count);
                    }

                }

                else if (action == "Switch")
                {
                    string old = commnad[1];
                    string current = commnad[2];

                    if (plan.Contains(old))
                    {
                        plan = plan.Replace(old, current);
                    }
                }

                Console.WriteLine(plan);

            }

            // output
            Console.WriteLine($"Ready for world tour! Planned stops: {plan}");
        }

        public static bool IsValid(int number, string plan)
        {
            bool isValid = number >= 0 && number <= plan.Length;

            return isValid;
        }
    }
}
