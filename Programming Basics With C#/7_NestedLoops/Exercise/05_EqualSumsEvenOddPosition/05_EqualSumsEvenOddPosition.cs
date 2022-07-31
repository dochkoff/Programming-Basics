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
            int count = 0;

            for (int i = n1; i <= n2; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    count = i % 10;
                    evenSum += count;
                    i /= 10;

                    if (i < 10)
                    {
                        oddSum += i;
                    }
                    else
                    {
                        count = i % 10;
                        oddSum += count;
                        i /= 10;
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

