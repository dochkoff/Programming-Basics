using System;

namespace OddEvenSum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int OddSum = 0;
            int EvenSum = 0;
            for (int i = 1; i <= n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    EvenSum += currentNumber;
                }
                else
                {
                    OddSum += currentNumber;
                }
            }

            if (EvenSum == OddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {EvenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(EvenSum - OddSum)}");
            }
        }
    }
}
