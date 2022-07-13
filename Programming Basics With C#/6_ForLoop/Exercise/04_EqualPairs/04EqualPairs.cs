using System;

namespace EqualPairs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double lastSum = 0;
            double firstSum = 0;
            double diff = 0;
            double maxDiff = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                double number1 = double.Parse(Console.ReadLine());
                double number2 = double.Parse(Console.ReadLine());

                firstSum = number1 + number2;

                if (n == 1)
                {
                    Console.WriteLine($"Yes, value={firstSum}");
                    return;
                }

                if (i > 0)
                {
                    diff = Math.Abs(firstSum - lastSum);
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }

                lastSum = firstSum;
            }

            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={lastSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={Math.Abs(maxDiff)}");
            }
        }
    }
}
