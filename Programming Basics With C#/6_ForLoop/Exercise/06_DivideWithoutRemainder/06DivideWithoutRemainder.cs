using System;

namespace DivideWithoutRemainder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int number = 0;
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;

            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    p1++;
                }

                if (number % 3 == 0)
                {
                    p2++;
                }

                if (number % 4 == 0)
                {
                    p3++;
                }
            }

            Console.WriteLine($"{(p1 / n * 100):F2}%");
            Console.WriteLine($"{(p2 / n * 100):F2}%");
            Console.WriteLine($"{(p3 / n * 100):F2}%");
        }
    }
}
