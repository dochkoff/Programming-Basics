using System;

namespace SpecialNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int x1 = 1; x1 < 9; x1++)
            {
                for (int x2 = 1; x2 < 9; x2++)
                {
                    for (int x3 = 1; x3 < 9; x3++)
                    {
                        for (int x4 = 1; x4 < 9; x4++)
                        {
                            if (N % x1 == 0 && N % x2 == 0 && N % x3 == 0 && N % x4 == 0)
                            {
                                Console.Write($"{x1}{x2}{x3}{x4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
