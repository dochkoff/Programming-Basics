using System;

namespace HalfSumElement
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int biggestNum = int.MinValue;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers > biggestNum)
                {
                    biggestNum = numbers;
                }

                sum += numbers;
            }

            if (sum - biggestNum == biggestNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum / 2}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(biggestNum * 2 - sum)}");
            }
        }
    }
}
