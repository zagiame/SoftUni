using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = Console.ReadLine();

            // calculation
            var brackets = new Stack<char>();
            bool isValid = false;

            if (brackets.Count() % 2 == 0)
            {
                foreach (char item in input)
                {
                    if (item == '(' || item == '{' || item == '[')
                    {
                        brackets.Push(item);
                    }

                    else
                    {
                        if (brackets.Any() == true)
                        {
                            bool isFirstValid = item == ')' && brackets.Pop() == '(';
                            bool isSecondValid = item == '}' && brackets.Pop() == '{';
                            bool isThirdValid = item == ']' && brackets.Pop() == '[';

                            if (isFirstValid == false && isSecondValid == false && isThirdValid == false)
                            {
                                isValid = false;
                                break;
                            }

                            else
                            {
                                isValid = true;
                            }
                        }
                    }
                }
            }

            // output
            if (isValid == true)
            {
                Console.WriteLine("YES");
            }

            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
