using System;

namespace _00_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double OddSum = 0.0;
            double OddMin = double.MaxValue;
            double OddMax = double.MinValue;
            double EvenSum = 0.0;
            double EvenMin = double.MaxValue;
            double EvenMax = double.MinValue;

            for (int i = 1; i <= n; i++) //
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    OddSum += number;

                    if (number > OddMax)
                    {
                        OddMax = number;
                    }

                    if (number < OddMin)
                    {
                        OddMin = number;
                    }
                }
            }
        }
    }
}

