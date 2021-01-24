using System;
using System.Linq;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string bigNumber = Console.ReadLine().TrimStart('0');
            int secondNum = int.Parse(Console.ReadLine());

            // calculation
            var stringBuilder = new StringBuilder();
            int temp = 0;

            if (secondNum == 0 || bigNumber == "")
            {
                Console.WriteLine('0');
                return;
            }

            foreach (var item in bigNumber.Reverse())
            {
                int current = int.Parse(item.ToString());
                int result = current * secondNum + temp;

                int toPrint = result % 10;
                temp = result / 10;

                stringBuilder.Insert(0, toPrint);
            }

            if (temp != 0)
            {
                stringBuilder.Insert(0, temp);
            }

            // ouput
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
