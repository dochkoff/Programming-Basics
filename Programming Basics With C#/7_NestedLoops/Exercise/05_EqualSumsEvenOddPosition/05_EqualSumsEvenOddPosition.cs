using System;

namespace _05_EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;

            for (int i = n1; i <= n2; i++)
            {
                int p = i;
                for (int x = 0; x < 3; x++)
                {
                    int count = p % 10;
                    evenSum += count;
                    p /= 10;

                    if (p < 10)
                    {
                        oddSum += p;
                    }
                    else
                    {
                        count = p % 10;
                        oddSum += count;
                        p /= 10;
                    }
                }

                if (oddSum == evenSum)
                {
                    Console.Write($"{i} ");
                }
                oddSum = 0;
                evenSum = 0;
            }
        }
    }
}