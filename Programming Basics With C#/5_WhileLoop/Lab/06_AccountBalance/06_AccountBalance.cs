using System;

namespace _06_AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int installmentsCount = int.Parse(Console.ReadLine());
            int counter = 0;
            double balance = 0;

            while (counter < installmentsCount)
            {
                double installment = double.Parse(Console.ReadLine());

                if (installment > 0)
                {
                    balance += installment;
                    Console.WriteLine($"Increase: {installment:F2}");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}

