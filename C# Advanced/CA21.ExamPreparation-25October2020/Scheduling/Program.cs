using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            var task = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            var thread = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int taskToBeKilled = int.Parse(Console.ReadLine());

            // calculation
            int killerThread = 0;

            while (task.Count > 0 && thread.Count > 0)
            {
                int currentTask = task.Peek();
                int currentThead = thread.Peek();

                if (currentTask == taskToBeKilled)
                {
                    task.Pop();
                    killerThread = currentThead;
                    break;
                }

                else if (currentThead < currentTask)
                {
                    thread.Dequeue();
                }

                else
                {
                    task.Pop();
                    thread.Dequeue();
                }
            }

            // output
            Console.WriteLine($"Thread with value {killerThread} killed task {taskToBeKilled}");

            if (thread.Count > 0)
            {
                Console.WriteLine(string.Join(" ", thread));
            }
        }
    }
}
