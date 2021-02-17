using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            List<string> input = Console.ReadLine().Split().ToList();

            // calculation
            string command = Console.ReadLine();

            while (command != "3:1")
            {
                string[] operation = command.Split();
                string currentAction = operation[0];
                int firstOperator = int.Parse(operation[1]);
                int secondOperator = int.Parse(operation[2]);

                if (currentAction == "merge")
                {
                    if (IsValidIndex(secondOperator, input.Count))
                    {
                        secondOperator = input.Count - 1;
                    }

                    for (int i = firstOperator; i < secondOperator; i++)
                    {
                        input[firstOperator] = input[firstOperator] + input[firstOperator + 1];
                        input.RemoveAt(firstOperator + 1);
                    }

                }

                else if (currentAction == "divide")
                {
                    string str = input[firstOperator];
                    int chunkSize = str.Length / secondOperator;
                    int stringLength = str.Length;
                    input.RemoveAt(firstOperator);
                    int positionCounter = 0;

                    for (int i = 0; i < stringLength; i += chunkSize)
                    {

                        if (i + chunkSize > stringLength) chunkSize = stringLength - i;
                        {
                            string index = str.Substring(i, chunkSize);

                            if (firstOperator + positionCounter > input.Count - 1)
                            {
                                input.Add(index);
                            }
                            else
                            {
                                input.Insert(firstOperator + positionCounter, index);
                            }
                        }

                        positionCounter++;

                    }

                    int oddDivide = stringLength % secondOperator;

                    if (oddDivide != 0)
                    {
                        int lastElement = positionCounter - 2;
                        int removeElement = positionCounter - 1;

                        input[lastElement] = input[lastElement] + input[removeElement];
                        input.RemoveAt(removeElement);

                    }

                }

                command = Console.ReadLine();
            }

            // output
            Console.WriteLine(string.Join(' ', input));
        }
        public static bool IsValidIndex(int index, int count)
        {
            return index > count || index < 0;
        }
    }
}

