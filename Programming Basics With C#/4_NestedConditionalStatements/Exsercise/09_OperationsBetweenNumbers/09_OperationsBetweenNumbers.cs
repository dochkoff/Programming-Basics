using System;

namespace OperationsBetweenNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char operand = Console.ReadLine()[0];

            double result = 0;

            if (operand == '+' || operand =='-' || operand == '*')
            {
                if (operand == '+')
                {
                    result = n1 + n2;
                }
                else if (operand == '-')
                {
                    result = n1 - n2;
                }
                else if (operand == '*')
                {
                    result = n1 * n2;
                }

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {operand} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {operand} {n2} = {result} - odd");
                }
            }

            else if (operand =='/' || operand == '%')
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else if (operand == '/')
                {
                    result = n1 * 1.0 / n2;
                    Console.WriteLine($"{n1} {operand} {n2} = {result:F2}");
                }
                else if (operand == '%')
                {
                    result = n1 % n2;
                    Console.WriteLine($"{n1} {operand} {n2} = {result}");
                }
            }
        }
    }
}
