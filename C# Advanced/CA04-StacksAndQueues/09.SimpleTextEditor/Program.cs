using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            // calculation
            var collention = new Stack<string>();
            string currentText = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string action = input[0];

                if (action == "1")
                {
                    string text = input[1];

                    if (collention.Any() == true)
                    {
                        currentText = collention.Peek() + text;
                        collention.Push(currentText);
                    }

                    else
                    {
                        collention.Push(text);
                    }
                }

                else if (action == "2")
                {
                    int count = int.Parse(input[1]);

                    if (collention.Any() == true)
                    {
                        currentText = collention.Peek();

                        for (int a = 0; a < count; a++)
                        {
                            currentText = currentText.Remove(currentText.Length - 1);
                        }

                        collention.Push(currentText);
                    }
                }

                else if (action == "3")
                {
                    int index = int.Parse(input[1]);

                    if (collention.Any() == true)
                    {
                        currentText = collention.Peek();
                        char print = currentText[index - 1];

                        Console.WriteLine(print);
                    }
                }

                else if (action == "4")
                {
                    if (collention.Any() == true)
                    {
                        collention.Pop();
                    }
                }
            }

            // output - none
        }
    }
}
