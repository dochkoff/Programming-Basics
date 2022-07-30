using System;

namespace _00_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int x1 = a; x1 <= b; x1++)
            {
                for (int x2 = a; x2 <= b; x2++)
                {
                    for (int x3 = c; x3 <= d; x3++)
                    {
                        for (int x4 = c; x4 <= d; x4++)
                        {
                            if (x1 + x4 == x2 + x3 && x1 != x2 && x3 != x4)
                            {
                                Console.WriteLine($"{x1}{x2}");
                                Console.WriteLine($"{x3}{x4}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
    }
}

