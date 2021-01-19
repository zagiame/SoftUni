using System;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string message = Console.ReadLine();

            // calcualtion
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Finish")
            {
                string[] commnad = input.Split();
                string action = commnad[0];

                switch (action)
                {
                    ////////////////////////////////////////////////////////////////

                    case "Replace":
                        string currentCar = commnad[1];
                        string newChar = commnad[2];

                        message = message.Replace(currentCar, newChar);
                        Console.WriteLine(message);
                        break;

                    ////////////////////////////////////////////////////////////////

                    case "Cut":
                        int startIndex = int.Parse(commnad[1]);
                        int endIndex = int.Parse(commnad[2]);
                        int count = endIndex - startIndex + 1;
                        bool valid = IsValid(startIndex, message) == true && IsValid(endIndex, message) == true;

                        if (valid == true && count + startIndex <= message.Length)
                        {
                            message = message.Remove(startIndex, count);
                            Console.WriteLine(message);
                        }

                        else
                        {
                            Console.WriteLine("Invalid indices!");
                        }

                        break;

                    ////////////////////////////////////////////////////////////////

                    case "Make":
                        string operation = commnad[1];

                        if (operation == "Upper")
                        {
                            message = message.ToUpper();
                        }

                        else
                        {
                            message = message.ToLower();
                        }

                        Console.WriteLine(message);
                        break;

                    ////////////////////////////////////////////////////////////////

                    case "Check":
                        string check = commnad[1];

                        if (message.Contains(check) == true)
                        {
                            Console.WriteLine($"Message contains {check}");
                        }

                        else
                        {
                            Console.WriteLine($"Message doesn't contain {check}");
                        }

                        break;

                    ////////////////////////////////////////////////////////////////

                    case "Sum":
                        startIndex = int.Parse(commnad[1]);
                        endIndex = int.Parse(commnad[2]);
                        count = endIndex - startIndex + 1;
                        valid = IsValid(startIndex, message) == true && IsValid(endIndex, message) == true;

                        if (valid == true && count + startIndex <= message.Length)
                        {
                            char[] table = message.Substring(startIndex, count).ToCharArray();
                            int sum = 0;

                            foreach (var item in table)
                            {
                                sum = sum + item;
                            }

                            Console.WriteLine(sum);
                        }

                        else
                        {
                            Console.WriteLine("Invalid indices!");
                        }


                        break;

                    ////////////////////////////////////////////////////////////////
                    ///
                    default:
                        break;
                }
            }

            // output
            // no output!?
        }

        public static bool IsValid(int number, string plan)
        {
            bool isValid = number >= 0 && number <= plan.Length;

            return isValid;
        }
    }
}
