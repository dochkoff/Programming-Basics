using System;

namespace _05_EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;
            int middleNum = 0;
            int count = 0;


            for (int i = n1; i <= n2; i++)
            {
                int p = i;

                for (int x = 0; x < 2; x++)
                {
                    count = p % 10;
                    rightSum += count;
                    p /= 10;
                }
                count = p % 10;
                middleNum = count;
                p /= 10;

                for (int x = 0; x < 2; x++)
                {
                    if (p >= 10)
                    {
                        count = p % 10;
                        leftSum += count;
                        p /= 10;
                    }
                    else
                    {
                        leftSum += p;
                    }
                }

                if (leftSum == rightSum || leftSum + middleNum == rightSum || rightSum + middleNum == leftSum)
                {
                    Console.Write($"{i} ");
                }
                leftSum = 0;
                rightSum = 0;
            }
        }
    }
}