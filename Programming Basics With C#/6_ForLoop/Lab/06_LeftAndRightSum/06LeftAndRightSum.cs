using System;

namespace LeftAndRightSum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < n * 2; i++)
            {
                if (i < n)
                {
                    int numbersLeft = int.Parse(Console.ReadLine());
                    sumLeft = sumLeft + numbersLeft;
                }
                else
                {
                    int numbersRight = int.Parse(Console.ReadLine());
                    sumRight = sumRight + numbersRight;
                }
            }
            int sum = Math.Abs(sumLeft - sumRight);

            if (sum == 0)
            {
                Console.WriteLine($"Yes, sum = {sumLeft}");
            }
            else
            {
                Console.WriteLine($"No, diff = {sum}");
            }
        }
    }
}
