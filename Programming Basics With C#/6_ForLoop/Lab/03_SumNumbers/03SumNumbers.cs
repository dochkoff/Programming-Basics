using System;

namespace SumNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int inputNumbers = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= inputNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum = sum + currentNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
