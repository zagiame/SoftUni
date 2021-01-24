using System;

namespace _04._Walking
{
    class Program
    {
        // static data
        static double stepsGoal = 10000;

        static void Main(string[] args)
        {
            // input

            // calculation
            double currentSteps = 0;
            double moreSteps = 0;
            double lessSteps = 0;
            double steps = 0;

            while (currentSteps < stepsGoal)
            {
                string operation = Console.ReadLine();
                if (operation == "Going home")
                {
                    steps = double.Parse(Console.ReadLine());
                    currentSteps = currentSteps + steps;
                    moreSteps = currentSteps - stepsGoal;
                    lessSteps = stepsGoal - currentSteps;

                    if (currentSteps > stepsGoal)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{moreSteps} steps over the goal!");
                        break;
                    }

                    else
                    {
                        Console.WriteLine($"{lessSteps} more steps to reach goal.");
                        break;
                    }
                }

                else
                {
                    steps = double.Parse(operation);
                    currentSteps = currentSteps + steps;
                    moreSteps = currentSteps - stepsGoal;
                    lessSteps = stepsGoal - currentSteps;

                    if (currentSteps > stepsGoal)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{moreSteps} steps over the goal!");
                        break;
                    }
                }
            }
        }
    }
}
